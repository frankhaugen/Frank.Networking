namespace Frank.IRC.Networking.Sockets;

public interface ISocketClient : IDisposable
{
    Task SendAsync(string message, CancellationToken cancellationToken);
}