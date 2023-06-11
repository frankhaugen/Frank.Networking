using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Commands;

public class WhoisCommand : Command
{
    public WhoisCommand() : base(CommandConstants.Whois.Command, CommandConstants.Whois.Helptext, CommandConstants.Whois.Syntax)
    {
    }
}