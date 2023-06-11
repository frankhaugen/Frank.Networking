namespace Frank.Networking.Legacy.Irc.Client;

public class IrcClient
{
    private readonly IOptions<IrcClientOptions> _options;
    private readonly ISocketSender _sender;

    public IrcClient(IOptions<IrcClientOptions> options, ISocketSender sender)
    {
        _options = options;
        _sender = sender;
    }
    
    public async Task ConnectAsync()
    {
    }
}