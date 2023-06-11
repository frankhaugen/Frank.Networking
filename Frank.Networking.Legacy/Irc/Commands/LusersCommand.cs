using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

public class LusersCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Lusers;

    public LusersCommand(string mask, string target) : base(mask, target)
    {
    }
    
    public string Mask => Parameters[0];
    public string Target => Parameters[1];
}