using System.Net;
using System.Net.Sockets;

namespace Frank.Networking.Legacy;

public class NetworkServer : NetworkResource
{
    public NetworkServer(ProtocolType protocolType) : base(protocolType)
    {
        Open(IPAddress.Any, 0);
    }
    
    public byte[] Receive()
    {
        byte[] data;
        
        switch (_protocolType)
        {
            case ProtocolType.Tcp:
                NetworkStream stream = _tcpClient.GetStream();
                data = new byte[1024];
                int bytesRead = stream.Read(data, 0, data.Length);
                Array.Resize(ref data, bytesRead);
                break;
            case ProtocolType.Udp:
                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);
                data = _udpClient.Receive(ref remoteEP);
                break;
            default:
                throw new NotSupportedException($"Unsupported protocol type: {_protocolType}");
        }

        return data;
    }
}