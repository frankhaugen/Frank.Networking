using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Commands;

public class PartCommand : Command
{
    public PartCommand() : base(CommandConstants.Part.Command, CommandConstants.Part.Helptext, CommandConstants.Part.Syntax)
    {
    }
}