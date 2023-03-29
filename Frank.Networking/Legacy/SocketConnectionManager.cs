using System.Collections.Concurrent;
using System.Net;

namespace Frank.Networking.Legacy;

public class SocketConnectionManager : ISocketConnectionManager
{
    private readonly ConcurrentDictionary<int, SocketConnection> _connections = new();
    
    public void Add(SocketConnection connection) => _connections.TryAdd(connection.GetSocketInfo().EndPoint.Port, connection);
    
    public void Remove(SocketConnection connection) => _connections.TryRemove(connection.GetSocketInfo().EndPoint.Port, out _);
    
    public SocketConnection Get(int port) => _connections[port];
    
    public SocketConnection Get(IPEndPoint endPoint) => _connections[endPoint.Port];
    
    public IEnumerable<SocketConnection> GetAll() => _connections.Values;
}