namespace Frank.IRC.Commands.Base;

public static class CommandNameExtensions
{
    public static ICommand ToCommand(this IrcCommandName command)
    {
        return command switch
        {
            IrcCommandName.Ping => new PingCommand(),
            IrcCommandName.Privmsg => new PrivateMessageCommand(),
            IrcCommandName.Quit => new QuitCommand(),
            IrcCommandName.User => new UserCommand(),
            IrcCommandName.Nick => new NickCommand(),
            IrcCommandName.Pass => new PasswordCommand(),
            IrcCommandName.Join => new JoinCommand(),
            IrcCommandName.Part => new PartCommand(),
            IrcCommandName.Mode => new ModeCommand(),
            IrcCommandName.Topic => new TopicCommand(),
            IrcCommandName.Whois => new WhoisCommand(),
            IrcCommandName.Who => new WhoCommand(),
            IrcCommandName.Whowas => new WhowasCommand(),
            IrcCommandName.List => new ListCommand(),
            IrcCommandName.Names => new NamesCommand(),
            IrcCommandName.Invite => new InviteCommand(),
            IrcCommandName.Kick => new KickCommand(),
            IrcCommandName.Version => new VersionCommand(),
            IrcCommandName.Stats => new StatsCommand(),
            IrcCommandName.Links => new LinksCommand(),
            IrcCommandName.Time => new TimeCommand(),
            IrcCommandName.Connect => new ConnectCommand(),
            IrcCommandName.Trace => new TraceCommand(),
            IrcCommandName.Admin => new AdminCommand(),
            IrcCommandName.Info => new InfoCommand(),
            IrcCommandName.Servlist => new ServerListCommand(),
            IrcCommandName.Squery => new SQueryCommand(),
            _ => throw new NotImplementedException()
        };
    }
}