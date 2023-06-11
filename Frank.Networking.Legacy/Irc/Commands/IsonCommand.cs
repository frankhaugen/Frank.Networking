using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

/// <summary>
/// The ISON command is used to check whether a client is online. It takes a list of nicknames as parameters and returns a list of those nicknames that are currently online.
/// </summary>
public class IsonCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Ison;
    
    /// <summary>
    /// The ISON command is used to check whether a client is online. It takes a list of nicknames as parameters and returns a list of those nicknames that are currently online.
    /// </summary>
    /// <param name="nicknames"></param>
    public IsonCommand(params string[] nicknames) : base(nicknames)
    {
    }
    
    public IReadOnlyList<string> Nicknames => Parameters;
}