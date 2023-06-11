using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Commands;

public class VersionCommand : Command
{
    public VersionCommand() : base(CommandConstants.Version.Command, CommandConstants.Version.Helptext, CommandConstants.Version.Syntax)
    {
    }
}