namespace Frank.IRC.Networking.Sockets;

public interface ISocketMessageQueue
{
    void Enqueue(SocketMessage message);
    SocketMessage Dequeue();
}