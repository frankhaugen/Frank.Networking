using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Commands;

public class SQueryCommand : Command
{
    public SQueryCommand() : base(CommandConstants.Squery.Command, CommandConstants.Squery.Helptext, CommandConstants.Squery.Syntax)
    {
    }
}