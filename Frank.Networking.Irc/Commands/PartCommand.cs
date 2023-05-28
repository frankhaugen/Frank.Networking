using Frank.IRC.Commands.Base;

namespace Frank.Networking.Irc;

public class PartCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Part;

    public PartCommand(string channel) : base(channel)
    {
    }
    
    public string Channel => Parameters[0];
}