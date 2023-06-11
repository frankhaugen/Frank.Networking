using System.Net;
using System.Net.Sockets;

namespace Frank.Networking.Common;

public abstract class NetworkConfiguration
{
    public IPAddress IPAddress { get; set; } = IPAddress.Any;
    public int Port { get; set; } = 6667; // IRC default port as it's unlikely to be used by anything else
    public ProtocolType ProtocolType { get; set; } = ProtocolType.Tcp;
    public SocketType SocketType { get; set; } = SocketType.Stream;
}