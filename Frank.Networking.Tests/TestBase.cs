using System.Net.Sockets;
using System.Text;

using Frank.IRC.Networking.Sockets;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using Xunit.Abstractions;

namespace Frank.IRC.Tests;

public class TestBase
{
    protected readonly ITestOutputHelper _outputHelper;
    
    protected IHost Host { get; private set; }
    protected IServiceCollection Services { get; } = new ServiceCollection();

    protected TestBase(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
    }
    
    protected void CreateHost() =>
        Host = Microsoft.Extensions.Hosting.Host.CreateDefaultBuilder()
            .ConfigureLogging(logging =>
            {
                logging.ClearProviders();
                // logging.AddTestLogger(_outputHelper);
                // logging.AddFileLogger(new DirectoryInfo("C:/temp/tests/logs"));
            })
            .ConfigureServices(services =>
            {
                foreach (var serviceDescriptor in Services)
                {
                    services.Replace(serviceDescriptor);
                }
            })
            .Build();

    protected async Task CreateAndRunAsync()
    {
        CreateHost();
        await Host.RunAsync();
    }
    
    protected async Task SendAsync(SocketMessage message)
    {
        var socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
        socket.Send(Encoding.UTF8.GetBytes(message.Message), SocketFlags.None);
        
        await Task.CompletedTask;
    }
}