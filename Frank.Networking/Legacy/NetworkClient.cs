using System.Net.Sockets;

namespace Frank.Networking.Legacy;

public class NetworkClient : NetworkResource
{
    public NetworkClient(ProtocolType protocolType) : base(protocolType)
    {
    }
    
    public void Send(byte[] data)
    {
        switch (_protocolType)
        {
            case ProtocolType.Tcp:
                NetworkStream stream = _tcpClient.GetStream();
                stream.Write(data, 0, data.Length);
                break;
            case ProtocolType.Udp:
                _udpClient.Send(data, data.Length);
                break;
            default:
                throw new NotSupportedException($"Unsupported protocol type: {_protocolType}");
        }
    }
}