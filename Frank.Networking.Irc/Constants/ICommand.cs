using Frank.IRC.Commands.Base;

namespace Frank.IRC;

public interface ICommand
{
    public IrcCommandName Name { get; }
    public string Description { get; }
    public string Syntax { get; }
    
    public IEnumerable<IReply> Replies { get; }
}