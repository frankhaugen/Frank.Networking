namespace Frank.IRC.Models;

public class IrcMessageRaw : IParsable<IrcMessageRaw>
{
    public IrcMessageRaw(string raw) => Raw = raw;

    public string Prefix { get; private set; }
    public string Command { get; private set; }
    public List<string> Parameters { get; } = new();
    public string Trailing { get; private set; }
    
    public string Raw { get; }

    public override string ToString()
    {
        var messageBuilder = new System.Text.StringBuilder();
        if (!string.IsNullOrEmpty(Prefix)) messageBuilder.Append($":{Prefix} ");
        messageBuilder.Append(Command);
        foreach (var parameter in Parameters) messageBuilder.Append($" {parameter}");
        if (!string.IsNullOrEmpty(Trailing)) messageBuilder.Append($" :{Trailing}");
        return messageBuilder.ToString();
    }

    public static IrcMessageRaw Parse(string s, IFormatProvider? provider)
    {
        if (string.IsNullOrEmpty(s))
            throw new ArgumentException("Raw message cannot be null or empty.");
        
        var result = new IrcMessageRaw(s);
        
        int position = 0;

        // Parse prefix
        if (s[0] == ':')
        {
            int prefixEnd = s.IndexOf(' ');
            result.Prefix = s.Substring(1, prefixEnd - 1);
            position = prefixEnd + 1;
        }

        // Parse command
        int commandEnd = s.IndexOf(' ', position);
        if (commandEnd < 0) commandEnd = s.Length;
        result.Command = s.Substring(position, commandEnd - position);
        position = commandEnd + 1;

        // Parse parameters and trailing
        while (position < s.Length)
        {
            // Trailing
            if (s[position] == ':')
            {
                result.Trailing = s.Substring(position + 1);
                break;
            }

            // Parameter
            int parameterEnd = s.IndexOf(' ', position);
            if (parameterEnd < 0)
            {
                // Last parameter
                result.Parameters.Add(s.Substring(position));
                break;
            }
            else
            {
                result.Parameters.Add(s.Substring(position, parameterEnd - position));
                position = parameterEnd + 1;
            }
        }
        
        return result;
    }

    public static bool TryParse(string? s, out IrcMessageRaw result) => TryParse(s, null, out result);
    
    public static bool TryParse(string? s, IFormatProvider? provider, out IrcMessageRaw result)
    {
        try
        {
            result = Parse(s!, provider);
            return true;
        }
        catch
        {
            result = null;
            return false;
        }
    }
}