using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

public class SQueryCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Squery;

    public SQueryCommand(string service, string text) 
        : base(service, text)
    {
    }
    
    public string Service => Parameters[0];
    public string Text => Parameters[1];
}