namespace Frank.Networking.Legacy;

public interface IDataReceivedHandler
{
    void OnDataReceived(object sender, TcpDataReceivedEventArgs e);
}