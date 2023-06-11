using Frank.Networking.Legacy.Irc.Commands;

namespace Frank.Networking.Legacy.Irc.Server;

public interface IIrcServer
{
    Task ReceiveCommandAsync(IIrcCommand command);
}