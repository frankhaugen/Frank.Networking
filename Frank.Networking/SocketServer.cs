using System.Net;
using System.Net.Sockets;
using System.Text;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Frank.Networking;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddTcpServer(this IServiceCollection services, SocketListenerOptions options)
    {
        services.AddSingleton<IOptions<SocketListenerOptions>>(Options.Create(options));
        services.AddSingleton<ISocketDataReceivedHandler, SocketDataReceivedHandler>();
        services.AddHostedService<SocketListener>();
        return services;
    }
    
}

public static class DependencyInjectionExtensions
{
    public static IServiceCollection AddSocketClient(this IServiceCollection services, SocketClientOptions options)
    {
        services.AddTransient<ISocketClient, SocketClient>();
        //services.AddSingleton<IOptions<SocketClientOptions>>(Options.Create(options));
        return services;
    }
}

public interface ISocketClient
{
    void SendMessage(string message, SocketClientOptions options);
    void Send(byte[] data, SocketClientOptions options);
}

public class SocketClientOptions
{
    public ProtocolType ProtocolType { get; set; }
    public SocketType SocketType { get; set; }
    public IPAddress IPAddress { get; set; }
    public int Port { get; set; }

    public SocketClientOptions(ProtocolType protocolType, SocketType socketType, IPAddress ipAddress, int port)
    {
        ProtocolType = protocolType;
        SocketType = socketType;
        IPAddress = ipAddress;
        Port = port;
    }

    public IPEndPoint ToIPEndpoint() => new IPEndPoint(IPAddress, Port);
}

public class SocketClient : ISocketClient
{
    private readonly ILogger<SocketClient> _logger;

    public SocketClient(ILogger<SocketClient> logger)
    {
        _logger = logger;
    }

    public void Send(byte[] data, SocketClientOptions options)
    {
        try
        {
            using var socket = new Socket(options.IPAddress.AddressFamily, options.SocketType, options.ProtocolType);
            socket.Connect(options.ToIPEndpoint());
            socket.Send(data);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error sending message: {ExceptionMessage}", ex.Message);
        }
    }

    public void SendMessage(string message, SocketClientOptions options)
    {
        var data = Encoding.UTF8.GetBytes(message);
        Send(data, options);
    }
}

public class SocketDataReceivedEventArgs : EventArgs
{
    public DateTime Timestamp { get; }
    public byte[] Data { get; }
    public EndPoint RemoteEndPoint { get; }

    public SocketDataReceivedEventArgs(EndPoint remoteEndPoint, byte[] data)
    {
        Timestamp = DateTime.UtcNow;
        Data = data;
        RemoteEndPoint = remoteEndPoint;
    }
}

public interface ISocketDataReceivedHandler
{
    void OnDataReceived(object sender, SocketDataReceivedEventArgs e);
}

public class SocketDataReceivedHandler : ISocketDataReceivedHandler
{
    private readonly ILogger<SocketDataReceivedHandler> _logger;
    
    public SocketDataReceivedHandler(ILogger<SocketDataReceivedHandler> logger)
    {
        _logger = logger;
    }
    
    public void OnDataReceived(object sender, SocketDataReceivedEventArgs e)
    {
        _logger.LogInformation("Data received from client {RemoteEndPoint}: {Data}", e.RemoteEndPoint, e.Data);
    }
}

public class SocketListenerOptions
{
    public ProtocolType ProtocolType { get; set; }
    public SocketType SocketType { get; set; }
    public IPAddress IPAddress { get; set; }
    public int Port { get; set; }
    public int Backlog { get; set; } = 100;
    
    public IPEndPoint ToIPEndpoint() => new IPEndPoint(IPAddress, Port);
}

public class SocketListener : BackgroundService
{
    private readonly IOptions<SocketListenerOptions> _options;
    private readonly ILogger<SocketListener> _logger;
    private readonly ISocketDataReceivedHandler _dataReceivedHandler;
    
    public SocketListener(IOptions<SocketListenerOptions> options, ILogger<SocketListener> logger, ISocketDataReceivedHandler dataReceivedHandler)
    {
        _options = options;
        _logger = logger;
        _dataReceivedHandler = dataReceivedHandler;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        using var listener = new Socket(_options.Value.IPAddress.AddressFamily, _options.Value.SocketType, _options.Value.ProtocolType);
        listener.Bind(_options.Value.ToIPEndpoint()); 
        listener.Listen(_options.Value.Backlog);

        while (!stoppingToken.IsCancellationRequested)
        {
            var client = await listener.AcceptAsync(stoppingToken);
            _ = Task.Run(() => HandleClientAsync(client), stoppingToken);
        }
    }

    private async Task HandleClientAsync(Socket client)
    {
        using (client)
        {
            var buffer = new byte[1024];

            while (client.Connected)
            {
                var bytesRead = await client.ReceiveAsync(new ArraySegment<byte>(buffer), SocketFlags.None);
                if (bytesRead > 0)
                {
                    using var stream = new MemoryStream();
                    await stream.ReadAsync(buffer, 0, bytesRead);
                    _dataReceivedHandler.OnDataReceived(this, new SocketDataReceivedEventArgs(client.RemoteEndPoint, stream.ToArray()));
                }
            }
        }
    }
}