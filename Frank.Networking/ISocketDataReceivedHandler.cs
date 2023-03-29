namespace Frank.Networking;

public interface ISocketDataReceivedHandler
{
    void OnDataReceived(object sender, SocketDataReceivedEventArgs e);
}