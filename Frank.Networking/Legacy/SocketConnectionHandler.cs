namespace Frank.Networking.Legacy;

public abstract class SocketConnectionHandler : ISocketConnectionHandler
{
    public async Task HandleAsync(SocketConnection connection, CancellationToken cancellationToken)
    {
        
    }
    
    protected abstract Task HandleAcceptedAsync(SocketConnection connection, CancellationToken cancellationToken);
    protected abstract Task HandleClosedAsync(SocketConnection connection, CancellationToken cancellationToken);
    protected abstract Task HandleErrorAsync(SocketConnection connection, CancellationToken cancellationToken);
    protected abstract Task HandleReceivedAsync(SocketConnection connection, CancellationToken cancellationToken);
    protected abstract Task HandleSentAsync(SocketConnection connection, CancellationToken cancellationToken);
    
}