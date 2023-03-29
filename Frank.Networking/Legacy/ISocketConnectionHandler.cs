namespace Frank.Networking.Legacy;

public interface ISocketConnectionHandler
{
    Task HandleAsync(SocketConnection connection, CancellationToken cancellationToken);
}