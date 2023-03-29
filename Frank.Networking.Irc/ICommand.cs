using Frank.IRC.Commands.Base;

namespace Frank.IRC;

public interface ICommand
{
    public CommandName Name { get; }
    public string Description { get; }
    public string Syntax { get; }
    
    public IEnumerable<IReply> Replies { get; }
}