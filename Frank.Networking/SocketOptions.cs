using System.Net.Sockets;

namespace Frank.Networking;

public class SocketOptions
{
    public AddressFamily AddressFamily { get; set; }
    public SocketType SocketType { get; set; }
    public ProtocolType ProtocolType { get; set; }
    
    public Socket ToSocket() => new Socket(AddressFamily, SocketType, ProtocolType);
}