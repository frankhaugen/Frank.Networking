using System.Net;

namespace Frank.Networking;

public class SocketDataReceivedEventArgs : EventArgs
{
    public DateTime Timestamp { get; }
    public byte[] Data { get; }
    public EndPoint RemoteEndPoint { get; }

    public SocketDataReceivedEventArgs(EndPoint remoteEndPoint, byte[] data)
    {
        Timestamp = DateTime.UtcNow;
        Data = data;
        RemoteEndPoint = remoteEndPoint;
    }
}