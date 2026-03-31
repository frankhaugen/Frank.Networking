namespace Frank.IRC.Networking.Sockets;

public interface ISocketMessageHandler
{
    public int Port { get; }
    
    Task HandleAsync(SocketMessage message, CancellationToken cancellationToken);
}