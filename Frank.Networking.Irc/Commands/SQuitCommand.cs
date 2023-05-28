using Frank.IRC.Commands.Base;

namespace Frank.Networking.Irc;

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