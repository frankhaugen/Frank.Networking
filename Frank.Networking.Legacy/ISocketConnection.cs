namespace Frank.Networking.Legacy;

public interface ISocketConnection
{
    Task SendAsync(byte[] data);
    Task<byte[]> ReceiveAsync();
}