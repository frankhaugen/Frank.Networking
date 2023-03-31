namespace Frank.IRC.Commands.Base;

public abstract class Command : ICommand
{
    public IrcCommandName Name { get; }
    public string Description { get; }
    public string Syntax { get; }
    
    public IEnumerable<IReply> Replies { get; }

    protected Command(IrcCommandName name, string description, string syntax)
    {
        Name = name;
        Description = description;
        Syntax = syntax;
    }
}