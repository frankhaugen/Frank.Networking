namespace Frank.Networking.Legacy.Irc.Models;

public class IrcPrefix
{
    public string Nickname { get; set; }
    public string Username { get; set; }
    public string Hostname { get; set; }
    
    public override string ToString()
    {
        return $"{Nickname}!{Username}@{Hostname}";
    }
    
    public static IrcPrefix Parse(string prefix)
    {
        var prefixParts = prefix.Split('!');
        var ircPrefix = new IrcPrefix
        {
            Nickname = prefixParts[0],
            Username = prefixParts[1].Split('@')[0],
            Hostname = prefixParts[1].Split('@')[1]
        };
        return ircPrefix;
    }
    
    public static bool TryParse(string prefix, out IrcPrefix ircPrefix)
    {
        try
        {
            ircPrefix = Parse(prefix);
            return true;
        }
        catch
        {
            ircPrefix = null;
            return false;
        }
    }
}