using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

public class PartCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Part;

    public PartCommand(string channel) : base(channel)
    {
    }
    
    public string Channel => Parameters[0];
}