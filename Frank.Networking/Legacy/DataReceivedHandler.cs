namespace Frank.Networking.Legacy;

public class DataReceivedHandler : IDataReceivedHandler
{
    public void OnDataReceived(object sender, TcpDataReceivedEventArgs e)
    {
        // Console.WriteLine($"Data received from client {e.Client.RemoteEndPoint}: {e.Data}");
    }
}