using Frank.IRC.Commands.Base;

namespace Frank.IRC.Commands;

public class WhoisCommand : Command
{
    public WhoisCommand() : base(CommandConstants.Whois.Command, CommandConstants.Whois.Helptext, CommandConstants.Whois.Syntax)
    {
    }
}