using System.Net.Sockets;

namespace Frank.Networking;

public interface ISocketFactory
{
    Socket CreateSocket(SocketOptions? options = null);
}