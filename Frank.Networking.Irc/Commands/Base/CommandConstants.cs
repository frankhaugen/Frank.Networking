namespace Frank.IRC.Commands.Base;

public class CommandConstants
{
    public static class Admin
    {
        public const string DisplayName = "Admin";
        public const CommandName Command = CommandName.ADMIN;
        public const string Syntax = "ADMIN [<server>]";
        public const string Helptext = "Asks the server for information about the administrator of the server <target>,If target is not used, the current server is used.";
    }

    public static class Away
    {
        public const string DisplayName = "Away";
        public const CommandName Command = CommandName.AWAY;
        public const string Syntax = "AWAY [<message>]";
        public const string Helptext = "GIves the server a message to send in reply to a PRIVMSG to the user. Removes away status if <message> is not used.";
    }

    public static class Connect
    {
        public const string DisplayName = "Connect";
        public const CommandName Command = CommandName.CONNECT;
        public const string Syntax = "CONNECT <target server> [<port> [<remote server>]] (RFC1459) CONNECT <target server> <port> [<remote server>] ( RFC2812)";
        public const string Helptext = "Tells the server <remote server> (or the current server, if <remote server> is not used) to connect to <target server> on port <port>. This command can normally only be used by IRC Operators.";
    }

    public static class Die
    {
        public const string DisplayName = "Die";
        public const CommandName Command = CommandName.DIE;
        public const string Syntax = "DIE";
        public const string Helptext = "Tells the server to shut down.";
    }

    public static class Error
    {
        public const string DisplayName = "Error";
        public const CommandName Command = CommandName.ERROR;
        public const string Syntax = "ERROR <error message>";
        public const string Helptext = "Use by servers to report errors to other servers. It is also used before ending client connections.";
    }

    public static class Info
    {
        public const string DisplayName = "Info";
        public const CommandName Command = CommandName.INFO;
        public const string Syntax = "INFO [<target>]";
        public const string Helptext = "Gives information about the <target> server, or the current server if <target> is not used The Information given includes the server's version, when it was compiled, the patch level, when it was started, and any other information which may be relevant.";
    }

    public static class Invite
    {
        public const string DisplayName = "Invite";
        public const CommandName Command = CommandName.INVITE;
        public const string Syntax = "INVITE <nickname> <channel>";
        public const string Helptext = "Invites <nickname> to the channel <channel>. <channel> does not have to exist. If it does, only members of the channel can invite other clients. If the channel mode i is set, only channel operators may invite other clients.";
    }

    public static class Ison
    {
        public const string DisplayName = "Ison";
        public const CommandName Command = CommandName.ISON;
        public const string Syntax = "ISON <nicknames>";
        public const string Helptext = "Asks the server to see if the clients in the list <nicknames> are on the network. The server returns the nicknames that are on the network. If none of the clients are on the network the server returns an empty list.";
    }

    public static class Join
    {
        public const string DisplayName = "Join";
        public const CommandName Command = CommandName.JOIN;
        public const string Syntax = "JOIN <channels> [<keys>]";
        public const string Helptext = "Makes the client join the channels in the list <channels> Passwords can be used in the list <keys>. If the channel(s) do not exist, they will be created.";
    }

    public static class Kick
    {
        public const string DisplayName = "Kick";
        public const CommandName Command = CommandName.KICK;
        public const string Syntax = "KICK <channel> <client> [<message>]";
        public const string Helptext = "Removes <client> from <channel>. This command may only be issued by channel operators.";
    }

    public static class Kill
    {
        public const string DisplayName = "Kill";
        public const CommandName Command = CommandName.KILL;
        public const string Syntax = "KILL <client> <comment>";
        public const string Helptext = "Removes <client> from the network. This command may only be used by IRC operators.";
    }

    public static class Links
    {
        public const string DisplayName = "Links";
        public const CommandName Command = CommandName.LINKS;
        public const string Syntax = "LINKS [<remote server> [<server mask>]]";
        public const string Helptext = "Lists all server links matching <server mask> on <remote server>, or the current server if <remote server> is not used.";
    }

    public static class List
    {
        public const string DisplayName = "List";
        public const CommandName Command = CommandName.LIST;
        public const string Syntax = "LIST [<channels> [<server>]]";
        public const string Helptext = "Lists all channels on the server. If the list <channels> is given, it will return the channel topics. If <server> is given, the command will be sent to <server> for evaluation.";
    }

    public static class Lusers
    {
        public const string DisplayName = "Lusers";
        public const CommandName Command = CommandName.LUSERS;
        public const string Syntax = "LUSERS [<mask> [<server>]]";
        public const string Helptext = "Returns statistics about the size of the network. If used with no arguments, the statistics will be about the entire network. If <mask> is given, it will return only statistics about the masked subset of the network. If <target> is given, the command will be sent to <server> for evaluation.";
    }

    public static class Mode
    {
        public const string DisplayName = "Mode";
        public const CommandName Command = CommandName.MODE;
        public const string Syntax = "MODE <nickname> <flags> (user) MODE <channel> <flags> [<args>]";
        public const string Helptext = "The MODE command is has two uses. It can be used to set both user and channel modes.";
    }

    public static class Motd
    {
        public const string DisplayName = "Motd";
        public const CommandName Command = CommandName.MOTD;
        public const string Syntax = "MOTD [<server>]";
        public const string Helptext = "Returns the message of the day on <server> or the current server if it is not stated.";
    }

    public static class Names
    {
        public const string DisplayName = "Names";
        public const CommandName Command = CommandName.NAMES;
        public const string Syntax = "NAMES [<channels>] (RFC1459) NAMES [<channels> [<server>]] ( RFC2812)";
        public const string Helptext = "Returns a list of who is on the list of <channels>, by channel name. If <channels> is not used, all users are shown,. They are grouped by channel name with all users who are not on a channel being shown as part of channel `*`. If <server> is specified, the command is sent to <server> for evaluation.";
    }

    public static class Nick
    {
        public const string DisplayName = "Nick";
        public const CommandName Command = CommandName.NICK;
        public const string Syntax = "NICK <nickname> [<hopcount>] (RFC1459) NICK <nickname> ( RFC2812)";
        public const string Helptext = "Allows a client to change their IRC nickname. Hopcount is for use between servers to say how far away a nickname is from its home server.";
    }

    public static class Notice
    {
        public const string DisplayName = "Notice";
        public const CommandName Command = CommandName.NOTICE;
        public const string Syntax = "NOTICE <msgtarget> <message>";
        public const string Helptext = "Similar to PRIVMSG, but automatic replies are never sent in reply to NOTICE messages.";
    }

    public static class Oper
    {
        public const string DisplayName = "Oper";
        public const CommandName Command = CommandName.OPER;
        public const string Syntax = "OPER <username> <password>";
        public const string Helptext = "Identifies a user as an IRC operator on that server/network.";
    }

    public static class Part
    {
        public const string DisplayName = "Part";
        public const CommandName Command = CommandName.PART;
        public const string Syntax = "PART <channels>";
        public const string Helptext = "Causes a user to leave the channels in the list <channels>.";
    }

    public static class Password
    {
        public const string DisplayName = "Password";
        public const CommandName Command = CommandName.PASS;
        public const string Syntax = "PASS <password>";
        public const string Helptext = "Sets a connection password. This command must be sent before the NICK/USER registration combination.";
    }

    public static class Ping
    {
        public const string DisplayName = "Ping";
        public const CommandName Command = CommandName.PING;
        public const string Syntax = "PING <server1> [<server2>]";
        public const string Helptext = "Tests a connection. A PING message results in a PONG reply. If <server2> is given, the message is sent to it.";
    }

    public static class Pong
    {
        public const string DisplayName = "Pong";
        public const CommandName Command = CommandName.PONG;
        public const string Syntax = "PONG <server2> [<server2>]";
        public const string Helptext = "This command is a reply to the PING command. It works in much the same way.";
    }

    public static class PrivateMessage
    {
        public const string DisplayName = "PrivateMessage";
        public const CommandName Command = CommandName.PRIVMSG;
        public const string Syntax = "PRIVMSG <msgtarget> <message>";
        public const string Helptext = "Sends <message> to <msgtarget>. The target is usually a user or channel.";
    }

    public static class Quit
    {
        public const string DisplayName = "Quit";
        public const CommandName Command = CommandName.QUIT;
        public const string Syntax = "QUIT [<message>]";
        public const string Helptext = "Disconnects the user from the server.";
    }

    public static class Rehash
    {
        public const string DisplayName = "Rehash";
        public const CommandName Command = CommandName.REHASH;
        public const string Syntax = "REHASH";
        public const string Helptext = "Causes the server to re-read and re-process its configuration file(s). This command can only be sent by IRC Operators.";
    }

    public static class Restart
    {
        public const string DisplayName = "Restart";
        public const CommandName Command = CommandName.RESTART;
        public const string Syntax = "RESTART";
        public const string Helptext = "Restarts a server. It may only be sent by IRC Operators.";
    }

    public static class Service
    {
        public const string DisplayName = "Service";
        public const CommandName Command = CommandName.SERVICE;
        public const string Syntax = "SERVICE <nickname> <reserved> <distribution> <type> <reserved> <info>";
        public const string Helptext = "Registers a new service on the network.";
    }

    public static class Servlist
    {
        public const string DisplayName = "Servlist";
        public const CommandName Command = CommandName.SERVLIST;
        public const string Syntax = "SERVLIST [<mask> [<type>]]";
        public const string Helptext = "Lists the services currently on the network.";
    }

    public static class Server
    {
        public const string DisplayName = "Server";
        public const CommandName Command = CommandName.SERVER;
        public const string Syntax = "SERVER <servername> <hopcount> <info>";
        public const string Helptext = "Used to tell a server that the other end of a new connection is a server. This message is also used to send server data over whole network. <hopcount> says how many hops (server connections) away <servername> is.<info> has information about the server.";
    }

    public static class Squery
    {
        public const string DisplayName = "Squery";
        public const CommandName Command = CommandName.SQUERY;
        public const string Syntax = "SQUERY <servicename> <text>";
        public const string Helptext = "Same as PRIVMSG except it must be sent to a service.";
    }

    public static class Squit
    {
        public const string DisplayName = "Squit";
        public const CommandName Command = CommandName.SQUIT;
        public const string Syntax = "SQUIT <server> <comment>";
        public const string Helptext = "Causes <server> to quit the network.";
    }

    public static class Stats
    {
        public const string DisplayName = "Stats";
        public const CommandName Command = CommandName.STATS;
        public const string Syntax = "STATS <query> [<server>]";
        public const string Helptext = "Returns statistics about the current server, or <server> if it is given.";
    }

    public static class Summon
    {
        public const string DisplayName = "Summon";
        public const CommandName Command = CommandName.SUMMON;
        public const string Syntax = "SUMMON <user> [<server>] (RFC1459 SUMMON <user> [<server> [<channel>]] ( RFC2812)";
        public const string Helptext = "Sends a message to users on the same host as <server> asking them to join IRC.";
    }

    public static class Time
    {
        public const string DisplayName = "Time";
        public const CommandName Command = CommandName.TIME;
        public const string Syntax = "TIME [<server>]";
        public const string Helptext = "Gives the local time on the current server, or <server> if specified.";
    }

    public static class Topic
    {
        public const string DisplayName = "Topic";
        public const CommandName Command = CommandName.TOPIC;
        public const string Syntax = "TOPIC <channel> [<topic>]";
        public const string Helptext = "Used to get the channel topic on <channel>. If <topic> is given, it sets the channel topic to <topic>. If channel mode +t is set, only a channel operator may set the topic.";
    }

    public static class Trace
    {
        public const string DisplayName = "Trace";
        public const CommandName Command = CommandName.TRACE;
        public const string Syntax = "TRACE [<target>]";
        public const string Helptext = "Trace a path across the IRC network to a specific server or client, in a similar method to traceroute.";
    }

    public static class User
    {
        public const string DisplayName = "User";
        public const CommandName Command = CommandName.USER;
        public const string Syntax = "USER <username> <hostname> <servername> <realname> (RFC1459) USER <user> <mode> <unused> <realname> ( RFC2812)";
        public const string Helptext = "This command is used at the beginning of a connection to specify the username, hostname, real name and initial user modes of the connecting client. <realname> may contain spaces, and thus must be prefixed with a colon.";
    }

    public static class Userhost
    {
        public const string DisplayName = "Userhost";
        public const CommandName Command = CommandName.USERHOST;
        public const string Syntax = "USERHOST <nickname> [<nickname> <nickname> ...]";
        public const string Helptext = "Returns a list of information about the nicknames specified.";
    }

    public static class Users
    {
        public const string DisplayName = "Users";
        public const CommandName Command = CommandName.USERS;
        public const string Syntax = "USERS [<server>]";
        public const string Helptext = "Returns a list of users and information about those users in a format similar to the UNIX commands who, rusers and finger.";
    }

    public static class Version
    {
        public const string DisplayName = "Version";
        public const CommandName Command = CommandName.VERSION;
        public const string Syntax = "VERSION [<server>]";
        public const string Helptext = "Returns the version of <server>, or the current server if omitted.";
    }

    public static class Wallops
    {
        public const string DisplayName = "Wallops";
        public const CommandName Command = CommandName.WALLOPS;
        public const string Syntax = "WALLOPS <message>";
        public const string Helptext = "Sends <message> to all operators connected to the server (RFC1459), or all users with user mode 'w' set ( RFC2812).";
    }

    public static class Who
    {
        public const string DisplayName = "Who";
        public const CommandName Command = CommandName.WHO;
        public const string Syntax = "WHO [<name> [`o`]]";
        public const string Helptext = "Returns a list of users who match <name>. If the flag `o` is given, the server will only return information about IRC Operators.";
    }

    public static class Whois
    {
        public const string DisplayName = "Whois";
        public const CommandName Command = CommandName.WHOIS;
        public const string Syntax = "WHOIS [<server>] <nicknames>";
        public const string Helptext = "Returns information about the comma-separated list of nicknames masks <nicknames>. If <server> is given, the command is forwarded to it for processing.";
    }

    public static class Whowas
    {
        public const string DisplayName = "Whowas";
        public const CommandName Command = CommandName.WHOWAS;
        public const string Syntax = "WHOWAS <nickname> [<count> [<server>]]";
        public const string Helptext = "Returns information about a nickname that is no longer in use (due to client disconnection, or nickname changes). If given, the server will return information from the last <count> times the nickname has been used. If <server> is given, the command is forwarded to it for processing. In RFC2812, <nickname> can be a comma-separated list of nicknames.";
    }
}

