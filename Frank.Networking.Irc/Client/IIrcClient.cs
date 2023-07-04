using Frank.Networking.Irc.Common;

namespace Frank.Networking.Irc.Client;

public interface IIrcClient
{
    Task<IrcMessage?> SendAsync(IrcMessage message, CancellationToken cancellationToken);
}