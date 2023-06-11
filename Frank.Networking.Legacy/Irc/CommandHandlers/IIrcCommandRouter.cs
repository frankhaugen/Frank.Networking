using Frank.Networking.Legacy.Irc.Models;

namespace Frank.Networking.Legacy.Irc.CommandHandlers;

public interface IIrcCommandRouter
{
    Task RouteAsync(IrcMessage message);
}