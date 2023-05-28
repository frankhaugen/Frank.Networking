using Frank.IRC.Commands.Base;
using Frank.IRC.Models;

namespace Frank.Networking.Irc.Helpers;

public static class IrcMessageExtensions
{
    public static IrcCommandName GetCommandName(this IrcMessageRaw message)
    {
        if (message == null)
            throw new ArgumentNullException(nameof(message));

        return CommandHelper.GetCommandName(message.Command);
    }
    
    public static IIrcCommand GetCommand(this IrcMessage message)
    {
        if (message == null)
            throw new ArgumentNullException(nameof(message));

        return message.Command switch
        {
            IrcCommandName.Admin => new AdminCommand(message.Parameters.First()),
            IrcCommandName.Away => new AwayCommand(message.Parameters.First()),
            IrcCommandName.Connect => new ConnectCommand(message.Parameters[0], message.Parameters[1], message.Parameters[2]),
            IrcCommandName.Die => new DieCommand(),
            IrcCommandName.Error => new ErrorCommand(message.Parameters.First()),
            IrcCommandName.Info => new InfoCommand(message.Parameters.First()),
            IrcCommandName.Invite => new InviteCommand(message.Parameters[0], message.Parameters[1]),
            IrcCommandName.Ison => new IsonCommand(message.Parameters.First()),
            IrcCommandName.Join => new JoinCommand(message.Parameters[0]),
            IrcCommandName.Kick => new KickCommand(message.Parameters[0], message.Parameters[1], message.Parameters[2]),
            IrcCommandName.Kill => new KillCommand(message.Parameters[0], message.Parameters[1]),
            IrcCommandName.Links => new LinksCommand(message.Parameters[0], message.Parameters[1]),
            IrcCommandName.List => new ListCommand(message.Parameters[0], message.Parameters[1]),
            IrcCommandName.Lusers => new LusersCommand(message.Parameters[0], message.Parameters[1]),
            IrcCommandName.Mode => new ModeCommand(message.Parameters[0], message.Parameters[1]),
            IrcCommandName.Motd => new MotdCommand(message.Parameters.First()),
            IrcCommandName.Names => new NamesCommand(message.Parameters[0], message.Parameters[1]),
            IrcCommandName.Nick => new NickCommand(message.Parameters[0]),
            IrcCommandName.Notice => new NoticeCommand(message.Parameters[0], message.Parameters[1]),
            IrcCommandName.Oper => new OperCommand(message.Parameters[0], message.Parameters[1]),
            IrcCommandName.Part => new PartCommand(message.Parameters[0]),
            IrcCommandName.Pass => new PassCommand(message.Parameters.First()),
            IrcCommandName.Ping => new PingCommand(message.Parameters.First()),
            IrcCommandName.Pong => new PongCommand(message.Parameters.First()),
            IrcCommandName.Privmsg => new PrivmsgCommand(message.Parameters[0], message.Parameters[1]),
            IrcCommandName.Quit => new QuitCommand(message.Parameters.First()),
            IrcCommandName.Rehash => new RehashCommand(),
            IrcCommandName.Restart => new RestartCommand(),
            IrcCommandName.Service => new ServiceCommand(message.Parameters[0], message.Parameters[1], message.Parameters[2], message.Parameters[3], message.Parameters[4]),
            IrcCommandName.Servlist => new ServerListCommand(message.Parameters[0], message.Parameters[1]),
            IrcCommandName.Server => new ServerCommand(message.Parameters[0], message.Parameters[1], message.Parameters[2]),
            IrcCommandName.Squery => new SQueryCommand(message.Parameters[0], message.Parameters[1]),
            IrcCommandName.Squit => new SQuitCommand(message.Parameters[0], message.Parameters[1]),
            IrcCommandName.Stats => new StatsCommand(message.Parameters[0], message.Parameters[1]),
            IrcCommandName.Summon => new SummonCommand(message.Parameters[0], message.Parameters[1]),
            IrcCommandName.Time => new TimeCommand(message.Parameters[0], message.Parameters[1]),
            IrcCommandName.Topic => new TopicCommand(message.Parameters[0], message.Parameters[1]),
            IrcCommandName.Trace => new TraceCommand(message.Parameters[0]),
            IrcCommandName.User => new UserCommand(message.Parameters[0], message.Parameters[1], message.Parameters[2], message.Parameters[3]),
            IrcCommandName.Userhost => new UserHostCommand(message.Parameters.First()),
            IrcCommandName.Users => new UsersCommand(message.Parameters[0]),
            IrcCommandName.Version => new VersionCommand(message.Parameters[0], message.Parameters[1]),
            IrcCommandName.Wallops => new WallopsCommand(message.Parameters.First()),
            IrcCommandName.Who => new WhoCommand(message.Parameters[0], message.Parameters[1]),
            IrcCommandName.Whois => new WhoIsCommand(message.Parameters[0], message.Parameters[1]),
            IrcCommandName.Whowas => new WhoWasCommand(message.Parameters[0], message.Parameters[1], message.Parameters[2]),
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}
