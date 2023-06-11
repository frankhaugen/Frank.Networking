namespace Frank.Networking.Legacy;

public interface ISocketConnectionFactory
{
    ISocketConnection Create();
}