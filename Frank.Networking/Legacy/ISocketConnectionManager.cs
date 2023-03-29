using System.Net;

namespace Frank.Networking.Legacy;

public interface ISocketConnectionManager
{
    void Add(SocketConnection connection);
    void Remove(SocketConnection connection);
    SocketConnection Get(int port);
    SocketConnection Get(IPEndPoint endPoint);
    IEnumerable<SocketConnection> GetAll();
}