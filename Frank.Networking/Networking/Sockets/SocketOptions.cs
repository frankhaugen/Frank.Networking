using System.Net.Sockets;

using Frank.IRC.Networking.Ports.Base;

namespace Frank.IRC.Networking.Sockets;

public class SocketOptions
{
    public PortType Port { get; set; }

    public SocketType Type { get; set; }
    
    public ProtocolType Protocol { get; set; }
}