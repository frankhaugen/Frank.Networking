namespace Frank.Networking;

public interface ISocketClient
{
    void SendMessage(string message, SocketClientOptions options);
    void Send(byte[] data, SocketClientOptions options);
}