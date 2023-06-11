namespace Frank.Networking.Legacy;

public interface ISocketConnectionDataReceivedHandler
{
    void OnDataReceived(object sender, SocketDataReceivedEventArgs e);
}