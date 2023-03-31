using Frank.IRC.Commands.Base;

namespace Frank.IRC.Commands;

public class VersionCommand : Command
{
    public VersionCommand() : base(CommandConstants.Version.Command, CommandConstants.Version.Helptext, CommandConstants.Version.Syntax)
    {
    }
}