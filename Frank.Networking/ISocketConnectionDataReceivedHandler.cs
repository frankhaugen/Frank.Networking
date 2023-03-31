namespace Frank.Networking;

public interface ISocketConnectionDataReceivedHandler
{
    void OnDataReceived(object sender, SocketDataReceivedEventArgs e);
}