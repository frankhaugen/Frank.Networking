namespace Frank.Networking.Legacy;

public interface ISocketDataReceivedHandler
{
    void OnDataReceived(object sender, SocketDataReceivedEventArgs e);
}