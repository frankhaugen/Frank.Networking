using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

public interface IIrcCommand
{
    IrcCommandName CommandName { get; }
    List<string> Parameters { get; }
    string ToString();
}