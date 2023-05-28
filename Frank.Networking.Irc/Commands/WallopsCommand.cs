using Frank.IRC.Commands.Base;

namespace Frank.Networking.Irc;

public class WallopsCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Wallops;

    public WallopsCommand(string text) : base(text)
    {
    }
    
    public string Text => Parameters[0];
}