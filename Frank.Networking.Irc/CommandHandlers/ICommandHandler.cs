using Frank.IRC.Commands;
using Frank.IRC.Commands.Base;
using Frank.IRC.Models;
using Frank.IRC.Replies;

namespace Frank.IRC.CommandHandlers;

public interface ICommandHandler
{
    public IrcCommandName Command { get; }
    
    public IEnumerable<IReply> Handle(IrcMessage message);
}