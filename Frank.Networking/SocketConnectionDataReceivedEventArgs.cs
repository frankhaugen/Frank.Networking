using System.Net;

namespace Frank.Networking;

public class SocketConnectionDataReceivedEventArgs : SocketConnectionEventArgs
{
    public SocketConnectionDataReceivedEventArgs(EndPoint remoteEndPoint, byte[] data)
    {
        RemoteEndPoint = remoteEndPoint;
        Data = data;
    }

    public EndPoint RemoteEndPoint { get; }
    public byte[] Data { get; }
}