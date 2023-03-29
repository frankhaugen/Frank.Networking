using System.Net;
using System.Net.Sockets;

namespace Frank.Networking;

public class SocketSenderOptions
{
    public ProtocolType ProtocolType { get; set; }
    public SocketType SocketType { get; set; }
    public IPAddress IPAddress { get; set; }
    public int Port { get; set; }

    public SocketSenderOptions(ProtocolType protocolType, SocketType socketType, IPAddress ipAddress, int port)
    {
        ProtocolType = protocolType;
        SocketType = socketType;
        IPAddress = ipAddress;
        Port = port;
    }

    public IPEndPoint ToIPEndpoint() => new IPEndPoint(IPAddress, Port);
}