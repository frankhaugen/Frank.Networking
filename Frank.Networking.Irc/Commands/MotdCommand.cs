using Frank.IRC.Commands.Base;

namespace Frank.Networking.Irc;

public class MotdCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Motd;

    public MotdCommand(string target) : base(target)
    {
    }
    
    public string Target => Parameters[0];
}