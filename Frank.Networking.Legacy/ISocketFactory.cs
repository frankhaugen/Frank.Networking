namespace Frank.Networking.Legacy;

public interface ISocketFactory
{
    Socket CreateSocket(SocketOptions? options = null);
}