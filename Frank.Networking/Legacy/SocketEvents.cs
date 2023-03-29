namespace Frank.Networking.Legacy;

public class SocketEvents
{
    public event EventHandler<SocketConnection> Accepted;
    public event EventHandler<SocketConnection> Closed;
    public event EventHandler<SocketConnection> Error;
    public event EventHandler<SocketConnection> Received;
    public event EventHandler<SocketConnection> Sent;

    public void OnAccepted(SocketConnection connection) => Accepted?.Invoke(this, connection);
    public void OnClosed(SocketConnection connection) => Closed?.Invoke(this, connection);
    public void OnConnectionError(SocketConnection connection) => Error?.Invoke(this, connection);
    public void OnReceived(SocketConnection connection) => Received?.Invoke(this, connection);
    public void OnSent(SocketConnection connection) => Sent?.Invoke(this, connection);
}