using Frank.IRC.Commands.Base;

namespace Frank.Networking.Irc.Helpers;

public static class CommandHelper
{
    public static IrcCommandName GetCommandName(string command)
    {
        if (string.IsNullOrWhiteSpace(command))
            throw new ArgumentNullException(nameof(command));

        if (command.Length > 1) 
            command = command.ToUpperInvariant();

        return command switch
        {
            "NICK" => IrcCommandName.Nick,
            "USER" => IrcCommandName.User,
            "JOIN" => IrcCommandName.Join,
            "PART" => IrcCommandName.Part,
            "PRIVMSG" => IrcCommandName.Privmsg,
            "NOTICE" => IrcCommandName.Notice,
            "PING" => IrcCommandName.Ping,
            "PONG" => IrcCommandName.Pong,
            "QUIT" => IrcCommandName.Quit,
            "MODE" => IrcCommandName.Mode,
            "TOPIC" => IrcCommandName.Topic,
            "INVITE" => IrcCommandName.Invite,
            "KICK" => IrcCommandName.Kick,
            "WHO" => IrcCommandName.Who,
            "WHOIS" => IrcCommandName.Whois,
            "WHOWAS" => IrcCommandName.Whowas,
            "KILL" => IrcCommandName.Kill,
            "ERROR" => IrcCommandName.Error,
            "AWAY" => IrcCommandName.Away,
            "REHASH" => IrcCommandName.Rehash,
            "RESTART" => IrcCommandName.Restart,
            "SUMMON" => IrcCommandName.Summon,
            "USERS" => IrcCommandName.Users,
            "WALLOPS" => IrcCommandName.Wallops,
            "USERHOST" => IrcCommandName.Userhost,
            "ISON" => IrcCommandName.Ison,
            _ => throw new ArgumentOutOfRangeException(nameof(command), command, "Unknown command")
        };
    }
}