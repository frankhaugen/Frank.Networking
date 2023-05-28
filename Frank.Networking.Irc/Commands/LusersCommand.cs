using Frank.IRC.Commands.Base;

namespace Frank.Networking.Irc;

public class LusersCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Lusers;

    public LusersCommand(string mask, string target) : base(mask, target)
    {
    }
    
    public string Mask => Parameters[0];
    public string Target => Parameters[1];
}