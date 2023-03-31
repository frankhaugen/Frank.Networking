using Frank.IRC.Commands.Base;

namespace Frank.Networking.Irc;

public interface IIrcCommand
{
    IrcCommandName CommandName { get; }
    List<string> Parameters { get; }
    string ToString();
}