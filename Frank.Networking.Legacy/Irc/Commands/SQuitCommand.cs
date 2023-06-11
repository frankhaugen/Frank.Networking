using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

public class SQuitCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Squit;

    public SQuitCommand(string server, string comment) 
        : base(server, comment)
    {
    }
    
    public string Server => Parameters[0];
    public string Comment => Parameters[1];
}