namespace Frank.Networking;

public interface ISocketConnectionFactory
{
    ISocketConnection Create();
}