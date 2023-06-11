using System.Net;
using System.Net.Sockets;

namespace Frank.Networking.Common;

public abstract class NetworkConfiguration
{
    /// <summary>
    /// IPAddress.Any is default
    /// </summary>
    public IPAddress IPAddress { get; set; } = IPAddress.Any;
    
    /// <summary>
    /// 6667 (IRC) is default
    /// </summary>
    public int Port { get; set; } = 6667; // IRC default port as it's unlikely to be used by anything else
    
    /// <summary>
    /// TCP is default
    /// </summary>
    public ProtocolType ProtocolType { get; set; } = ProtocolType.Tcp;
    
    /// <summary>
    /// Stream is default
    /// </summary>
    public SocketType SocketType { get; set; } = SocketType.Stream;
}