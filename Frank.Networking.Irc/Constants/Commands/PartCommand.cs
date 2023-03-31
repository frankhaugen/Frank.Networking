using Frank.IRC.Commands.Base;

namespace Frank.IRC.Commands;

public class PartCommand : Command
{
    public PartCommand() : base(CommandConstants.Part.Command, CommandConstants.Part.Helptext, CommandConstants.Part.Syntax)
    {
    }
}