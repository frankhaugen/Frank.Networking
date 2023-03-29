using Frank.IRC.Commands.Base;

namespace Frank.IRC.Models;

public class IrcMessage
{
    public IrcPrefix Prefix { get; }
    public IrcCommandName Command { get; }
    public IrcParameters Parameters { get; } = new();
    public string Trailing { get; }
    
    public IrcMessage(IrcMessageRaw rawMessage)
    {
        Prefix = IrcPrefix.Parse(rawMessage.Prefix);
        Command = Enum.Parse<IrcCommandName>(rawMessage.Command);
        Parameters.AddRange(rawMessage.Parameters);
        Trailing = rawMessage.Trailing;
    }
    
    public override string ToString()
    {
        var messageBuilder = new System.Text.StringBuilder();
        messageBuilder.Append($":{Prefix} ");
        messageBuilder.Append(Command);
        foreach (var parameter in Parameters) messageBuilder.Append($" {parameter}");
        messageBuilder.Append($" :{Trailing}");
        return messageBuilder.ToString();
    }
}