using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

public abstract class IrcCommand : IIrcCommand
{
    public abstract IrcCommandName CommandName { get; }
    public List<string> Parameters { get; protected set; }

    public IrcCommand(params string[] parameters)
    {
        Parameters = new List<string>(parameters);
    }

    public override string ToString()
    {
        string paramString = Parameters.Count > 0 ? " " + string.Join(" ", Parameters) : "";
        return $"{CommandName}{paramString}\r\n";
    }
}