namespace Frank.Networking.Legacy;

public class SocketConnectionListener : ISocketConnectionListener
{
    private readonly IOptions<SocketConnectionOptions> _options;
    
    public SocketConnectionListener(IOptions<SocketConnectionOptions> options) => _options = options;
    
    public bool IsListening { get; private set; }
    
    public event EventHandler<SocketConnectionDataReceivedEventArgs>? DataReceived;

    public async Task ListenAsync(CancellationToken stoppingToken = default)
    {
        IsListening = true;
        using var socket = _options.Value.ToSocket();
        socket.Bind(_options.Value.ToIPEndpoint());
        socket.Listen(100);
        
        while (!stoppingToken.IsCancellationRequested)
        {
            var client = await socket.AcceptAsync(stoppingToken);
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
                    _ = await stream.ReadAsync(buffer, 0, bytesRead);
                    DataReceived?.Invoke(this, new SocketConnectionDataReceivedEventArgs(client.RemoteEndPoint, stream.ToArray()));
                    // _dataReceivedHandler.OnDataReceived(this, new SocketDataReceivedEventArgs(client.RemoteEndPoint, stream.ToArray()));
                }
            }
        }
    }
}