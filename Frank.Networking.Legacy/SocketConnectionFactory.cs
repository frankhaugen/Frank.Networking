namespace Frank.Networking.Legacy;

public class SocketConnectionFactory : ISocketConnectionFactory
{
    private readonly IOptions<SocketConnectionOptions> _options;

    public SocketConnectionFactory(IOptions<SocketConnectionOptions> options) => _options = options;

    public ISocketConnection Create() => new SocketConnection(_options);
}