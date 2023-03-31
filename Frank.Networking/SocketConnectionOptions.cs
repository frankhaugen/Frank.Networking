using System.Net;
using System.Net.Sockets;

namespace Frank.Networking;

public interface ISocketConnectionHandler
{
    void OnDataReceived(object sender, SocketConnectionDataReceivedEventArgs e);
}


public class SocketConnectionOptions
{
    public IPAddress IPAddress { get; set; }
    public int Port { get; set; }
    public SocketType SocketType { get; set; }
    public ProtocolType ProtocolType { get; set; }
    
    public IPEndPoint ToIPEndpoint() => new IPEndPoint(IPAddress, Port);
    
    public Socket ToSocket() => new Socket(IPAddress.AddressFamily, SocketType, ProtocolType);
}