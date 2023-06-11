using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Constants;

public interface ICommand
{
    public IrcCommandName Name { get; }
    public string Description { get; }
    public string Syntax { get; }
    
    public IEnumerable<IReply> Replies { get; }
}