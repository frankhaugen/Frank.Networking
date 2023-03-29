using System.Net;
using System.Net.Sockets;

namespace Frank.Networking;

public class SocketListenerOptions
{
    public ProtocolType ProtocolType { get; set; }
    public SocketType SocketType { get; set; }
    public IPAddress IPAddress { get; set; }
    public int Port { get; set; }
    public int Backlog { get; set; } = 100;
    
    public IPEndPoint ToIPEndpoint() => new IPEndPoint(IPAddress, Port);
}