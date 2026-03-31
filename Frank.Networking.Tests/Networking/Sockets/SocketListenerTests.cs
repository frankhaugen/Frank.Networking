using System.Net;
using System.Net.Sockets;
using System.Text;

using Frank.IRC.Networking;
using Frank.IRC.Networking.Ports.Base;
using Frank.IRC.Networking.Sockets;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using Xunit.Abstractions;

namespace Frank.IRC.Tests.Networking.Sockets;

public class SocketListenerTests : TestBase
{
    public SocketListenerTests(ITestOutputHelper outputHelper) : base(outputHelper)
    {
    }
    
    [Fact]
    public async Task Test()
    {
        var options = new SocketOptions
        {
            Port = PortType.Irc,
            Protocol = ProtocolType.Tcp,
            Type = SocketType.Stream
        };
        
        Services.AddSocketClient(options);

        Services.AddSocketServer(options, new GenericHandler((int)PortType.Irc));
        
        Services.AddHostedService<SendService>();
        
        await CreateAndRunAsync();
        
        _outputHelper.WriteLine("Goodbye World");

        await Task.Delay(TimeSpan.FromSeconds(1));
        
        await Host.StopAsync();
    }
    
    private class SendService : BackgroundService
    {
        private readonly ILogger<SendService> _logger;
        private readonly ISocketClient _socketClient;

        public SendService(ILogger<SendService> logger, ISocketClient socketClient)
        {
            _logger = logger;
            _socketClient = socketClient;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            
            await Task.Delay(TimeSpan.FromSeconds(10), stoppingToken);
            
            _logger.LogInformation("Hello World from SendService");
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    await _socketClient.SendAsync("Hello World", stoppingToken);
                }
                catch (Exception e)
                {
                    _logger.LogError(e, "Error sending message");
                }
                finally
                {
                    await Task.Delay(TimeSpan.FromSeconds(1), stoppingToken);
                }
            }
            
            _logger.LogInformation("Goodbye World from SendService");
        }
    }
}