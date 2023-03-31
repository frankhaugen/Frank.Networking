namespace Frank.IRC.Replies.Base;

public abstract class Reply : IReply
{
    public string Name { get; }
    public int Number { get; }
    
    public string Description { get; }

    protected Reply(string name, int number, string description)
    {
        Name = name;
        Number = number;
        Description = description;
    }
}