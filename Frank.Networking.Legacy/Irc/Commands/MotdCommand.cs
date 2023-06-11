using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

public class MotdCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Motd;

    public MotdCommand(string target) : base(target)
    {
    }
    
    public string Target => Parameters[0];
}