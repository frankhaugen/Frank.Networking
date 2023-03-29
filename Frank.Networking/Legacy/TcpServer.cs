using System.Net.Sockets;
using System.Text;

using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Frank.Networking.Legacy;

public class TcpServer : BackgroundService
{
    private readonly IOptions<TcpServerOptions> _options;
    private readonly ILogger<TcpServer> _logger;
    
    private Socket _listener;
    private bool _isRunning;
    
    public TcpServer(IOptions<TcpServerOptions> options, ILogger<TcpServer> logger)
    {
        _options = options;
        _logger = logger;
    }

    public event EventHandler<TcpDataReceivedEventArgs> DataReceived;

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _listener = new Socket(_options.Value.IPAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        _listener.Bind(_options.Value.ToIPEndpoint());
        _listener.Listen(100);

        _isRunning = true;

        while (_isRunning)
        {
            var client = await _listener.AcceptAsync();
            _ = Task.Run(() => HandleClientAsync(client));
        }
    }

    public override async Task StopAsync(CancellationToken stoppingToken)
    {
        _isRunning = false;
        _listener.Close();   
        await base.StopAsync(stoppingToken);
    }

    private async Task HandleClientAsync(Socket client)
    {
        using (client)
        {
            var buffer = new byte[1024];

            while (_isRunning && client.Connected)
            {
                var bytesRead = await client.ReceiveAsync(new ArraySegment<byte>(buffer), SocketFlags.None);
                if (bytesRead > 0)
                {
                    var data = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    DataReceived?.Invoke(this, new TcpDataReceivedEventArgs(client.RemoteEndPoint, data));
                }
            }
        }
    }
}