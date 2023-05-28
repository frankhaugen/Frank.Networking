using Frank.IRC.Commands.Base;

namespace Frank.Networking.Irc;

public class ModeCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Mode;

    public ModeCommand(string target, string mode) : base(target, mode)
    {
    }
    
    public string Target => Parameters[0];
    public string Mode => Parameters[1];
}