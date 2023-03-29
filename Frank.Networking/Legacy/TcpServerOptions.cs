using System.Net;

namespace Frank.Networking.Legacy;

public class TcpServerOptions
{
    public IPAddress IPAddress { get; set; }
    public int Port { get; set; }
    
    public IPEndPoint ToIPEndpoint() => new IPEndPoint(IPAddress, Port);
}