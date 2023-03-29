namespace Frank.IRC.Commands.Base;

public static class CommandNameExtensions
{
    public static ICommand ToCommand(this IrcCommandName command)
    {
        return command switch
        {
            IrcCommandName.PING => new PingCommand(),
            IrcCommandName.PRIVMSG => new PrivateMessageCommand(),
            IrcCommandName.QUIT => new QuitCommand(),
            IrcCommandName.USER => new UserCommand(),
            IrcCommandName.NICK => new NickCommand(),
            IrcCommandName.PASS => new PasswordCommand(),
            IrcCommandName.JOIN => new JoinCommand(),
            IrcCommandName.PART => new PartCommand(),
            IrcCommandName.MODE => new ModeCommand(),
            IrcCommandName.TOPIC => new TopicCommand(),
            IrcCommandName.WHOIS => new WhoisCommand(),
            IrcCommandName.WHO => new WhoCommand(),
            IrcCommandName.WHOWAS => new WhowasCommand(),
            IrcCommandName.LIST => new ListCommand(),
            IrcCommandName.NAMES => new NamesCommand(),
            IrcCommandName.INVITE => new InviteCommand(),
            IrcCommandName.KICK => new KickCommand(),
            IrcCommandName.VERSION => new VersionCommand(),
            IrcCommandName.STATS => new StatsCommand(),
            IrcCommandName.LINKS => new LinksCommand(),
            IrcCommandName.TIME => new TimeCommand(),
            IrcCommandName.CONNECT => new ConnectCommand(),
            IrcCommandName.TRACE => new TraceCommand(),
            IrcCommandName.ADMIN => new AdminCommand(),
            IrcCommandName.INFO => new InfoCommand(),
            IrcCommandName.SERVLIST => new ServerListCommand(),
            IrcCommandName.SQUERY => new SQueryCommand(),
            _ => throw new NotImplementedException()
        };
    }
}