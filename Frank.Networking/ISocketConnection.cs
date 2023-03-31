namespace Frank.Networking;

public interface ISocketConnection
{
    Task SendAsync(byte[] data);
    Task<byte[]> ReceiveAsync();
}