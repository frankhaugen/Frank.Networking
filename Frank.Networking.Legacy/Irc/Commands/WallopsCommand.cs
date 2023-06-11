using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

public class WallopsCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Wallops;

    public WallopsCommand(string text) : base(text)
    {
    }
    
    public string Text => Parameters[0];
}