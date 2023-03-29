namespace Frank.Networking;

public interface ISocketSender
{
    Task SendAsync(byte[] data);
}