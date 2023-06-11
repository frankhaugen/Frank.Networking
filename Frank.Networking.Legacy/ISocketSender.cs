namespace Frank.Networking.Legacy;

public interface ISocketSender
{
    Task SendAsync(byte[] data);
    Task SendAsync(byte[] data, SocketConnectionOptions options);
}