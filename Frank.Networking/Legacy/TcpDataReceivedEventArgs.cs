using System.Net;

namespace Frank.Networking.Legacy;

public class TcpDataReceivedEventArgs : EventArgs
{
    public string Data { get; }
    public EndPoint RemoteEndPoint { get; }

    public TcpDataReceivedEventArgs(EndPoint remoteEndPoint, string data)
    {
        Data = data;
        RemoteEndPoint = remoteEndPoint;
    }
}