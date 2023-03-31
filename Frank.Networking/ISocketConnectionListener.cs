namespace Frank.Networking;

public interface ISocketConnectionListener
{
    bool IsListening { get; }
    event EventHandler<SocketConnectionDataReceivedEventArgs>? DataReceived;
    Task ListenAsync(CancellationToken stoppingToken = default);
}