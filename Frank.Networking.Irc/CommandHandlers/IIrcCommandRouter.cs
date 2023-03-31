using Frank.IRC.Models;

namespace Frank.IRC.CommandHandlers;

public interface IIrcCommandRouter
{
    Task RouteAsync(IrcMessage message);
}