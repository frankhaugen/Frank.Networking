using System.Collections.Concurrent;

namespace Frank.IRC.Networking.Sockets;

public class SocketMessageQueue : ISocketMessageQueue
{
    private readonly ConcurrentQueue<SocketMessage> _queue = new();
 
    public void Enqueue(SocketMessage message) => _queue.Enqueue(message);

    public SocketMessage Dequeue()
    {
        _queue.TryDequeue(out var message);
        return message;
    }
}