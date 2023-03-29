namespace Frank.IRC.Commands.Base;

public static class CommandNameExtensions
{
    public static ICommand ToCommand(this CommandName command)
    {
        return command switch
        {
            CommandName.PING => new PingCommand(),
            CommandName.PRIVMSG => new PrivateMessageCommand(),
            CommandName.QUIT => new QuitCommand(),
            CommandName.USER => new UserCommand(),
            CommandName.NICK => new NickCommand(),
            CommandName.PASS => new PasswordCommand(),
            CommandName.JOIN => new JoinCommand(),
            CommandName.PART => new PartCommand(),
            CommandName.MODE => new ModeCommand(),
            CommandName.TOPIC => new TopicCommand(),
            CommandName.WHOIS => new WhoisCommand(),
            CommandName.WHO => new WhoCommand(),
            CommandName.WHOWAS => new WhowasCommand(),
            CommandName.LIST => new ListCommand(),
            CommandName.NAMES => new NamesCommand(),
            CommandName.INVITE => new InviteCommand(),
            CommandName.KICK => new KickCommand(),
            CommandName.VERSION => new VersionCommand(),
            CommandName.STATS => new StatsCommand(),
            CommandName.LINKS => new LinksCommand(),
            CommandName.TIME => new TimeCommand(),
            CommandName.CONNECT => new ConnectCommand(),
            CommandName.TRACE => new TraceCommand(),
            CommandName.ADMIN => new AdminCommand(),
            CommandName.INFO => new InfoCommand(),
            CommandName.SERVLIST => new ServerListCommand(),
            CommandName.SQUERY => new SQueryCommand(),
            _ => throw new NotImplementedException()
        };
    }
}