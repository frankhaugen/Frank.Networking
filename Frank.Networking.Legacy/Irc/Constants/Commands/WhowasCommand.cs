using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Commands;

public class WhowasCommand : Command
{
    public WhowasCommand() : base(CommandConstants.Whowas.Command, CommandConstants.Whowas.Helptext, CommandConstants.Whowas.Syntax)
    {
    }
}