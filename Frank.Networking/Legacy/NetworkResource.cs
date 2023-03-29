using System.Net;
using System.Net.Sockets;

namespace Frank.Networking.Legacy;

public abstract class NetworkResource
{

    protected readonly TcpClient _tcpClient;
    protected readonly UdpClient _udpClient;
    protected readonly ProtocolType _protocolType;

    protected NetworkResource(ProtocolType protocolType)
    {
        _protocolType = protocolType;
        
        switch (_protocolType)
        {
            case ProtocolType.Tcp:
                _tcpClient = new TcpClient();
                break;
            case ProtocolType.Udp:
                _udpClient = new UdpClient();
                break;
            default:
                throw new NotSupportedException($"Unsupported protocol type: {_protocolType}");
        }
    }

    public void Open(IPAddress address, int port)
    {
        switch (_protocolType)
        {
            case ProtocolType.Tcp:
                _tcpClient.Connect(address, port);
                break;
            case ProtocolType.Udp:
                _udpClient.Connect(address, port);
                break;
            default:
                throw new NotSupportedException($"Unsupported protocol type: {_protocolType}");
        }
    }

    public void Close()
    {
        switch (_protocolType)
        {
            case ProtocolType.Tcp:
                _tcpClient.Close();
                break;
            case ProtocolType.Udp:
                _udpClient.Close();
                break;
            default:
                throw new NotSupportedException($"Unsupported protocol type: {_protocolType}");
        }
    }
    
}