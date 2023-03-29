namespace Frank.IRC.Commands.Base;

public abstract class Command : ICommand
{
    public CommandName Name { get; }
    public string Description { get; }
    public string Syntax { get; }
    
    public IEnumerable<IReply> Replies { get; }

    protected Command(CommandName name, string description, string syntax)
    {
        Name = name;
        Description = description;
        Syntax = syntax;
    }
}