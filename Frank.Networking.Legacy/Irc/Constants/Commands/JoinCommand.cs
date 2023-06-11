using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Commands;

public class JoinCommand : Command
{
    public JoinCommand() : base(CommandConstants.Join.Command, CommandConstants.Join.Helptext, CommandConstants.Join.Syntax)
    {
    }
}