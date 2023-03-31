namespace Frank.IRC.Replies.Base;

public static class ReplyConstants
{
    public static class Welcome
    {
        public const string DisplayName = "Welcome";
        public const string Name = "RPL_WELCOME";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 1;
        public const string Format = "<client> :Welcome to the Internet Relay Network <nick>!<user>@<host>";
    }
    public static class Yourhost
    {
        public const string DisplayName = "Yourhost";
        public const string Name = "RPL_YOURHOST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 2;
        public const string Format = "<client> :Your host is <servername>, running version <version>";
    }
    public static class Created
    {
        public const string DisplayName = "Created";
        public const string Name = "RPL_CREATED";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 3;
        public const string Format = "<client> :This server was created <date>";
    }
    public static class Myinfo
    {
        public const string DisplayName = "Myinfo";
        public const string Name = "RPL_MYINFO";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 4;
        public const string Format = "<client> <server_name> <version> <usermodes> <chanmodes> [chanmodes_with_a_parameter]";
    }
    public static class Bounce
    {
        public const string DisplayName = "Bounce";
        public const string Name = "RPL_BOUNCE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 5;
        public const string Format = "<client> :Try server <server_name>, port <port_number>";
    }
    public static class Isupport
    {
        public const string DisplayName = "Isupport";
        public const string Name = "RPL_ISUPPORT";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 5;
        public const string Format = "<client> <1-13 tokens> :are supported by this server";
    }
    public static class Map
    {
        public const string DisplayName = "Map";
        public const string Name = "RPL_MAP";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 6;
        public const string Format = "";
    }
    public static class Mapend
    {
        public const string DisplayName = "Mapend";
        public const string Name = "RPL_MAPEND";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 7;
        public const string Format = "";
    }
    public static class Snomask
    {
        public const string DisplayName = "Snomask";
        public const string Name = "RPL_SNOMASK";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 8;
        public const string Format = "";
    }
    public static class Statmemtot
    {
        public const string DisplayName = "Statmemtot";
        public const string Name = "RPL_STATMEMTOT";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 9;
        public const string Format = "";
    }
    public static class Statmem
    {
        public const string DisplayName = "Statmem";
        public const string Name = "RPL_STATMEM";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 10;
        public const string Format = "";
    }
    public static class Yourcookie
    {
        public const string DisplayName = "Yourcookie";
        public const string Name = "RPL_YOURCOOKIE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 14;
        public const string Format = "";
    }
    public static class Mapmore
    {
        public const string DisplayName = "Mapmore";
        public const string Name = "RPL_MAPMORE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 16;
        public const string Format = "";
    }
    public static class Mapusers
    {
        public const string DisplayName = "Mapusers";
        public const string Name = "RPL_MAPUSERS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 18;
        public const string Format = "<client> :<count> servers and <count> users, average <average count> users per server";
    }
    public static class Hello
    {
        public const string DisplayName = "Hello";
        public const string Name = "RPL_HELLO";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 20;
        public const string Format = "<client> :<info>";
    }
    public static class Apasswarn_set
    {
        public const string DisplayName = "Apasswarn_set";
        public const string Name = "RPL_APASSWARN_SET";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 30;
        public const string Format = "";
    }
    public static class Apasswarn_secret
    {
        public const string DisplayName = "Apasswarn_secret";
        public const string Name = "RPL_APASSWARN_SECRET";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 31;
        public const string Format = "";
    }
    public static class Apasswarn_clear
    {
        public const string DisplayName = "Apasswarn_clear";
        public const string Name = "RPL_APASSWARN_CLEAR";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 32;
        public const string Format = "";
    }
    public static class Yourid
    {
        public const string DisplayName = "Yourid";
        public const string Name = "RPL_YOURID";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 42;
        public const string Format = "";
    }
    public static class Savenick
    {
        public const string DisplayName = "Savenick";
        public const string Name = "RPL_SAVENICK";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 43;
        public const string Format = "<client> <newnick> :<info>";
    }
    public static class Attemptingjunc
    {
        public const string DisplayName = "Attemptingjunc";
        public const string Name = "RPL_ATTEMPTINGJUNC";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 50;
        public const string Format = "";
    }
    public static class Attemptingreroute
    {
        public const string DisplayName = "Attemptingreroute";
        public const string Name = "RPL_ATTEMPTINGREROUTE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 51;
        public const string Format = "";
    }
    public static class Remoteisupport
    {
        public const string DisplayName = "Remoteisupport";
        public const string Name = "RPL_REMOTEISUPPORT";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 105;
        public const string Format = "";
    }
    public static class Tracelink
    {
        public const string DisplayName = "Tracelink";
        public const string Name = "RPL_TRACELINK";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 200;
        public const string Format = "<client> Link <version>[.<debug_level>] <destination> <next_server> [V<protocol_version> <link_uptime_in_seconds> <backstream_sendq> <upstream_sendq>]";
    }
    public static class Traceconnecting
    {
        public const string DisplayName = "Traceconnecting";
        public const string Name = "RPL_TRACECONNECTING";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 201;
        public const string Format = "<client> Try. <class> <server>";
    }
    public static class Tracehandshake
    {
        public const string DisplayName = "Tracehandshake";
        public const string Name = "RPL_TRACEHANDSHAKE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 202;
        public const string Format = "<client> H.S. <class> <server>";
    }
    public static class Traceunknown
    {
        public const string DisplayName = "Traceunknown";
        public const string Name = "RPL_TRACEUNKNOWN";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 203;
        public const string Format = "<client> ???? <class> [<connection_address>]";
    }
    public static class Traceoperator
    {
        public const string DisplayName = "Traceoperator";
        public const string Name = "RPL_TRACEOPERATOR";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 204;
        public const string Format = "<client> Oper <class> <nick>";
    }
    public static class Traceuser
    {
        public const string DisplayName = "Traceuser";
        public const string Name = "RPL_TRACEUSER";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 205;
        public const string Format = "<client> User <class> <nick>";
    }
    public static class Traceserver
    {
        public const string DisplayName = "Traceserver";
        public const string Name = "RPL_TRACESERVER";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 206;
        public const string Format = "<client> Serv <class> <int>S <int>C <server> <nick!user|*!*>@<host|server> [V<protocol_version>]";
    }
    public static class Traceservice
    {
        public const string DisplayName = "Traceservice";
        public const string Name = "RPL_TRACESERVICE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 207;
        public const string Format = "<client> Service <class> <name> <type> <active_type>";
    }
    public static class Tracenewtype
    {
        public const string DisplayName = "Tracenewtype";
        public const string Name = "RPL_TRACENEWTYPE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 208;
        public const string Format = "<client> <newtype> 0 <client_name>";
    }
    public static class Traceclass
    {
        public const string DisplayName = "Traceclass";
        public const string Name = "RPL_TRACECLASS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 209;
        public const string Format = "<client> Class <class> <count>";
    }
    public static class Tracereconnect
    {
        public const string DisplayName = "Tracereconnect";
        public const string Name = "RPL_TRACERECONNECT";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 210;
        public const string Format = "";
    }
    public static class Stats
    {
        public const string DisplayName = "Stats";
        public const string Name = "RPL_STATS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 210;
        public const string Format = "";
    }
    public static class Statshelp
    {
        public const string DisplayName = "Statshelp";
        public const string Name = "RPL_STATSHELP";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 210;
        public const string Format = "";
    }
    public static class Statslinkinfo
    {
        public const string DisplayName = "Statslinkinfo";
        public const string Name = "RPL_STATSLINKINFO";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 211;
        public const string Format = "<client> <linkname> <sendq> <sent_msgs> <sent_bytes> <recvd_msgs> <rcvd_bytes> <time_open>";
    }
    public static class Statscommands
    {
        public const string DisplayName = "Statscommands";
        public const string Name = "RPL_STATSCOMMANDS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 212;
        public const string Format = "<client> <command> <count> [<byte_count> <remote_count>]";
    }
    public static class Statscline
    {
        public const string DisplayName = "Statscline";
        public const string Name = "RPL_STATSCLINE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 213;
        public const string Format = "<client> C <host> * <name> <port> <class>";
    }
    public static class Statsnline
    {
        public const string DisplayName = "Statsnline";
        public const string Name = "RPL_STATSNLINE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 214;
        public const string Format = "<client> N <host> * <name> <port> <class>";
    }
    public static class Statsiline
    {
        public const string DisplayName = "Statsiline";
        public const string Name = "RPL_STATSILINE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 215;
        public const string Format = "<client> I <host> * <host> <port> <class>";
    }
    public static class Statskline
    {
        public const string DisplayName = "Statskline";
        public const string Name = "RPL_STATSKLINE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 216;
        public const string Format = "<client> K <host> * <username> <port> <class>";
    }
    public static class Statsqline
    {
        public const string DisplayName = "Statsqline";
        public const string Name = "RPL_STATSQLINE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 217;
        public const string Format = "";
    }
    public static class Statspline
    {
        public const string DisplayName = "Statspline";
        public const string Name = "RPL_STATSPLINE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 217;
        public const string Format = "";
    }
    public static class Statsyline
    {
        public const string DisplayName = "Statsyline";
        public const string Name = "RPL_STATSYLINE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 218;
        public const string Format = "<client> Y <class> <ping_freq> <connect_freq> <max_sendq>";
    }
    public static class Endofstats
    {
        public const string DisplayName = "Endofstats";
        public const string Name = "RPL_ENDOFSTATS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 219;
        public const string Format = "<client> <query> :<info>";
    }
    public static class Statsbline
    {
        public const string DisplayName = "Statsbline";
        public const string Name = "RPL_STATSBLINE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 220;
        public const string Format = "";
    }
    public static class Statswline
    {
        public const string DisplayName = "Statswline";
        public const string Name = "RPL_STATSWLINE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 220;
        public const string Format = "";
    }
    public static class Umodeis
    {
        public const string DisplayName = "Umodeis";
        public const string Name = "RPL_UMODEIS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 221;
        public const string Format = "<client> <user_modes> [<user_mode_params>]";
    }
    public static class Modlist
    {
        public const string DisplayName = "Modlist";
        public const string Name = "RPL_MODLIST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 222;
        public const string Format = "";
    }
    public static class Sqline_nick
    {
        public const string DisplayName = "Sqline_nick";
        public const string Name = "RPL_SQLINE_NICK";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 222;
        public const string Format = "";
    }
    public static class Statsjline
    {
        public const string DisplayName = "Statsjline";
        public const string Name = "RPL_STATSJLINE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 222;
        public const string Format = "";
    }
    public static class Codepage
    {
        public const string DisplayName = "Codepage";
        public const string Name = "RPL_CODEPAGE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 222;
        public const string Format = "";
    }
    public static class Statseline
    {
        public const string DisplayName = "Statseline";
        public const string Name = "RPL_STATSELINE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 223;
        public const string Format = "";
    }
    public static class Statsgline
    {
        public const string DisplayName = "Statsgline";
        public const string Name = "RPL_STATSGLINE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 223;
        public const string Format = "";
    }
    public static class Charset
    {
        public const string DisplayName = "Charset";
        public const string Name = "RPL_CHARSET";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 223;
        public const string Format = "";
    }
    public static class Statsfline
    {
        public const string DisplayName = "Statsfline";
        public const string Name = "RPL_STATSFLINE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 224;
        public const string Format = "";
    }
    public static class Statstline
    {
        public const string DisplayName = "Statstline";
        public const string Name = "RPL_STATSTLINE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 224;
        public const string Format = "";
    }
    public static class Statsdline
    {
        public const string DisplayName = "Statsdline";
        public const string Name = "RPL_STATSDLINE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 225;
        public const string Format = "";
    }
    public static class Statsclone
    {
        public const string DisplayName = "Statsclone";
        public const string Name = "RPL_STATSCLONE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 225;
        public const string Format = "";
    }
    public static class Statszline
    {
        public const string DisplayName = "Statszline";
        public const string Name = "RPL_STATSZLINE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 225;
        public const string Format = "";
    }
    public static class Statscount
    {
        public const string DisplayName = "Statscount";
        public const string Name = "RPL_STATSCOUNT";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 226;
        public const string Format = "";
    }
    public static class Statsaline
    {
        public const string DisplayName = "Statsaline";
        public const string Name = "RPL_STATSALINE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 226;
        public const string Format = "";
    }
    public static class Statsvline
    {
        public const string DisplayName = "Statsvline";
        public const string Name = "RPL_STATSVLINE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 227;
        public const string Format = "";
    }
    public static class Statsbanver
    {
        public const string DisplayName = "Statsbanver";
        public const string Name = "RPL_STATSBANVER";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 228;
        public const string Format = "";
    }
    public static class Statsspamf
    {
        public const string DisplayName = "Statsspamf";
        public const string Name = "RPL_STATSSPAMF";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 229;
        public const string Format = "";
    }
    public static class Statsexcepttkl
    {
        public const string DisplayName = "Statsexcepttkl";
        public const string Name = "RPL_STATSEXCEPTTKL";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 230;
        public const string Format = "";
    }
    public static class Serviceinfo
    {
        public const string DisplayName = "Serviceinfo";
        public const string Name = "RPL_SERVICEINFO";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 231;
        public const string Format = "";
    }
    public static class Endofservices
    {
        public const string DisplayName = "Endofservices";
        public const string Name = "RPL_ENDOFSERVICES";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 232;
        public const string Format = "";
    }
    public static class Rules
    {
        public const string DisplayName = "Rules";
        public const string Name = "RPL_RULES";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 232;
        public const string Format = "";
    }
    public static class Service
    {
        public const string DisplayName = "Service";
        public const string Name = "RPL_SERVICE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 233;
        public const string Format = "";
    }
    public static class Servlist
    {
        public const string DisplayName = "Servlist";
        public const string Name = "RPL_SERVLIST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 234;
        public const string Format = "<client> <name> <server> <mask> <type> <hopcount> <info>";
    }
    public static class Servlistend
    {
        public const string DisplayName = "Servlistend";
        public const string Name = "RPL_SERVLISTEND";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 235;
        public const string Format = "<client> <mask> <type> :<info>";
    }
    public static class Statsverbose
    {
        public const string DisplayName = "Statsverbose";
        public const string Name = "RPL_STATSVERBOSE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 236;
        public const string Format = "";
    }
    public static class Statsengine
    {
        public const string DisplayName = "Statsengine";
        public const string Name = "RPL_STATSENGINE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 237;
        public const string Format = "";
    }
    public static class Statsiauth
    {
        public const string DisplayName = "Statsiauth";
        public const string Name = "RPL_STATSIAUTH";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 239;
        public const string Format = "";
    }
    public static class Statsxline
    {
        public const string DisplayName = "Statsxline";
        public const string Name = "RPL_STATSXLINE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 240;
        public const string Format = "";
    }
    public static class Statslline
    {
        public const string DisplayName = "Statslline";
        public const string Name = "RPL_STATSLLINE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 241;
        public const string Format = "<client> L <hostmask> * <servername> <maxdepth>";
    }
    public static class Statsuptime
    {
        public const string DisplayName = "Statsuptime";
        public const string Name = "RPL_STATSUPTIME";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 242;
        public const string Format = "<client> :Server Up <days> days <hours>:<minutes>:<seconds>";
    }
    public static class Statsoline
    {
        public const string DisplayName = "Statsoline";
        public const string Name = "RPL_STATSOLINE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 243;
        public const string Format = "<client> O <hostmask> * <opername> [<privileges>] <class>";
    }
    public static class Statshline
    {
        public const string DisplayName = "Statshline";
        public const string Name = "RPL_STATSHLINE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 244;
        public const string Format = "<client> H <hostmask> * <servername>";
    }
    public static class Statssline
    {
        public const string DisplayName = "Statssline";
        public const string Name = "RPL_STATSSLINE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 245;
        public const string Format = "";
    }
    public static class Statsping
    {
        public const string DisplayName = "Statsping";
        public const string Name = "RPL_STATSPING";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 246;
        public const string Format = "";
    }
    public static class Statsservice
    {
        public const string DisplayName = "Statsservice";
        public const string Name = "RPL_STATSSERVICE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 246;
        public const string Format = "";
    }
    public static class Statsuline
    {
        public const string DisplayName = "Statsuline";
        public const string Name = "RPL_STATSULINE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 246;
        public const string Format = "";
    }
    public static class Statsdefine
    {
        public const string DisplayName = "Statsdefine";
        public const string Name = "RPL_STATSDEFINE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 248;
        public const string Format = "";
    }
    public static class Statsdebug
    {
        public const string DisplayName = "Statsdebug";
        public const string Name = "RPL_STATSDEBUG";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 249;
        public const string Format = "";
    }
    public static class Statsconn
    {
        public const string DisplayName = "Statsconn";
        public const string Name = "RPL_STATSCONN";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 250;
        public const string Format = "";
    }
    public static class Luserclient
    {
        public const string DisplayName = "Luserclient";
        public const string Name = "RPL_LUSERCLIENT";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 251;
        public const string Format = "<client> :There are <int> users and <int> invisible on <int> servers";
    }
    public static class Luserop
    {
        public const string DisplayName = "Luserop";
        public const string Name = "RPL_LUSEROP";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 252;
        public const string Format = "<client> <int> :operator(s) online";
    }
    public static class Luserunknown
    {
        public const string DisplayName = "Luserunknown";
        public const string Name = "RPL_LUSERUNKNOWN";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 253;
        public const string Format = "<client> <int> :unknown connection(s)";
    }
    public static class Luserchannels
    {
        public const string DisplayName = "Luserchannels";
        public const string Name = "RPL_LUSERCHANNELS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 254;
        public const string Format = "<client> <int> :channels formed";
    }
    public static class Luserme
    {
        public const string DisplayName = "Luserme";
        public const string Name = "RPL_LUSERME";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 255;
        public const string Format = "<client> :I have <int> clients and <int> servers";
    }
    public static class Adminme
    {
        public const string DisplayName = "Adminme";
        public const string Name = "RPL_ADMINME";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 256;
        public const string Format = "<client> <server> :Administrative info";
    }
    public static class Adminloc1
    {
        public const string DisplayName = "Adminloc1";
        public const string Name = "RPL_ADMINLOC1";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 257;
        public const string Format = "<client> :<admin_location>";
    }
    public static class Adminloc2
    {
        public const string DisplayName = "Adminloc2";
        public const string Name = "RPL_ADMINLOC2";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 258;
        public const string Format = "<client> :<admin_location>";
    }
    public static class Adminemail
    {
        public const string DisplayName = "Adminemail";
        public const string Name = "RPL_ADMINEMAIL";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 259;
        public const string Format = "<client> :<email_address>";
    }
    public static class Tracelog
    {
        public const string DisplayName = "Tracelog";
        public const string Name = "RPL_TRACELOG";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 261;
        public const string Format = "<client> File <logfile> <debug_level>";
    }
    public static class Traceping
    {
        public const string DisplayName = "Traceping";
        public const string Name = "RPL_TRACEPING";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 262;
        public const string Format = "";
    }
    public static class Traceend
    {
        public const string DisplayName = "Traceend";
        public const string Name = "RPL_TRACEEND";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 262;
        public const string Format = "<client> <server_name> <version>[.<debug_level>] :<info>";
    }
    public static class Tryagain
    {
        public const string DisplayName = "Tryagain";
        public const string Name = "RPL_TRYAGAIN";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 263;
        public const string Format = "<client> <command> :Please wait a while and try again.";
    }
    public static class Usingssl
    {
        public const string DisplayName = "Usingssl";
        public const string Name = "RPL_USINGSSL";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 264;
        public const string Format = "";
    }
    public static class Localusers
    {
        public const string DisplayName = "Localusers";
        public const string Name = "RPL_LOCALUSERS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 265;
        public const string Format = "<client> [<u> <m>] :Current local users <u>, max <m>";
    }
    public static class Globalusers
    {
        public const string DisplayName = "Globalusers";
        public const string Name = "RPL_GLOBALUSERS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 266;
        public const string Format = "<client> [<u> <m>] :Current global users <u>, max <m>";
    }
    public static class Start_netstat
    {
        public const string DisplayName = "Start_netstat";
        public const string Name = "RPL_START_NETSTAT";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 267;
        public const string Format = "";
    }
    public static class Netstat
    {
        public const string DisplayName = "Netstat";
        public const string Name = "RPL_NETSTAT";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 268;
        public const string Format = "";
    }
    public static class End_netstat
    {
        public const string DisplayName = "End_netstat";
        public const string Name = "RPL_END_NETSTAT";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 269;
        public const string Format = "";
    }
    public static class Privs
    {
        public const string DisplayName = "Privs";
        public const string Name = "RPL_PRIVS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 270;
        public const string Format = "";
    }
    public static class Silelist
    {
        public const string DisplayName = "Silelist";
        public const string Name = "RPL_SILELIST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 271;
        public const string Format = "";
    }
    public static class Endofsilelist
    {
        public const string DisplayName = "Endofsilelist";
        public const string Name = "RPL_ENDOFSILELIST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 272;
        public const string Format = "";
    }
    public static class Notify
    {
        public const string DisplayName = "Notify";
        public const string Name = "RPL_NOTIFY";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 273;
        public const string Format = "";
    }
    public static class Endnotify
    {
        public const string DisplayName = "Endnotify";
        public const string Name = "RPL_ENDNOTIFY";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 274;
        public const string Format = "";
    }
    public static class Statsdelta
    {
        public const string DisplayName = "Statsdelta";
        public const string Name = "RPL_STATSDELTA";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 274;
        public const string Format = "";
    }
    public static class Whoiscertfp
    {
        public const string DisplayName = "Whoiscertfp";
        public const string Name = "RPL_WHOISCERTFP";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 276;
        public const string Format = "<client> <nick> :has client certificate fingerprint <fingerprint>";
    }
    public static class Statsrline
    {
        public const string DisplayName = "Statsrline";
        public const string Name = "RPL_STATSRLINE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 276;
        public const string Format = "";
    }
    public static class Vchanexist
    {
        public const string DisplayName = "Vchanexist";
        public const string Name = "RPL_VCHANEXIST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 276;
        public const string Format = "";
    }
    public static class Vchanlist
    {
        public const string DisplayName = "Vchanlist";
        public const string Name = "RPL_VCHANLIST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 277;
        public const string Format = "";
    }
    public static class Vchanhelp
    {
        public const string DisplayName = "Vchanhelp";
        public const string Name = "RPL_VCHANHELP";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 278;
        public const string Format = "";
    }
    public static class Glist
    {
        public const string DisplayName = "Glist";
        public const string Name = "RPL_GLIST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 280;
        public const string Format = "";
    }
    public static class Endofglist
    {
        public const string DisplayName = "Endofglist";
        public const string Name = "RPL_ENDOFGLIST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 281;
        public const string Format = "";
    }
    public static class Acceptlist
    {
        public const string DisplayName = "Acceptlist";
        public const string Name = "RPL_ACCEPTLIST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 281;
        public const string Format = "";
    }
    public static class Endofaccept
    {
        public const string DisplayName = "Endofaccept";
        public const string Name = "RPL_ENDOFACCEPT";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 282;
        public const string Format = "";
    }
    public static class Jupelist
    {
        public const string DisplayName = "Jupelist";
        public const string Name = "RPL_JUPELIST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 282;
        public const string Format = "";
    }
    public static class Alist
    {
        public const string DisplayName = "Alist";
        public const string Name = "RPL_ALIST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 283;
        public const string Format = "";
    }
    public static class Endofjupelist
    {
        public const string DisplayName = "Endofjupelist";
        public const string Name = "RPL_ENDOFJUPELIST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 283;
        public const string Format = "";
    }
    public static class Endofalist
    {
        public const string DisplayName = "Endofalist";
        public const string Name = "RPL_ENDOFALIST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 284;
        public const string Format = "";
    }
    public static class Feature
    {
        public const string DisplayName = "Feature";
        public const string Name = "RPL_FEATURE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 284;
        public const string Format = "";
    }
    public static class Glist_hash
    {
        public const string DisplayName = "Glist_hash";
        public const string Name = "RPL_GLIST_HASH";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 285;
        public const string Format = "";
    }
    public static class Chaninfo_handle
    {
        public const string DisplayName = "Chaninfo_handle";
        public const string Name = "RPL_CHANINFO_HANDLE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 285;
        public const string Format = "";
    }
    public static class Newhostis
    {
        public const string DisplayName = "Newhostis";
        public const string Name = "RPL_NEWHOSTIS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 285;
        public const string Format = "";
    }
    public static class Chaninfo_users
    {
        public const string DisplayName = "Chaninfo_users";
        public const string Name = "RPL_CHANINFO_USERS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 286;
        public const string Format = "";
    }
    public static class Chkhead
    {
        public const string DisplayName = "Chkhead";
        public const string Name = "RPL_CHKHEAD";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 286;
        public const string Format = "";
    }
    public static class Chaninfo_chops
    {
        public const string DisplayName = "Chaninfo_chops";
        public const string Name = "RPL_CHANINFO_CHOPS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 287;
        public const string Format = "";
    }
    public static class Chanuser
    {
        public const string DisplayName = "Chanuser";
        public const string Name = "RPL_CHANUSER";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 287;
        public const string Format = "";
    }
    public static class Chaninfo_voices
    {
        public const string DisplayName = "Chaninfo_voices";
        public const string Name = "RPL_CHANINFO_VOICES";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 288;
        public const string Format = "";
    }
    public static class Patchhead
    {
        public const string DisplayName = "Patchhead";
        public const string Name = "RPL_PATCHHEAD";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 288;
        public const string Format = "";
    }
    public static class Chaninfo_away
    {
        public const string DisplayName = "Chaninfo_away";
        public const string Name = "RPL_CHANINFO_AWAY";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 289;
        public const string Format = "";
    }
    public static class Patchcon
    {
        public const string DisplayName = "Patchcon";
        public const string Name = "RPL_PATCHCON";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 289;
        public const string Format = "";
    }
    public static class Chaninfo_opers
    {
        public const string DisplayName = "Chaninfo_opers";
        public const string Name = "RPL_CHANINFO_OPERS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 290;
        public const string Format = "";
    }
    public static class Helphdr
    {
        public const string DisplayName = "Helphdr";
        public const string Name = "RPL_HELPHDR";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 290;
        public const string Format = "";
    }
    public static class Datastr
    {
        public const string DisplayName = "Datastr";
        public const string Name = "RPL_DATASTR";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 290;
        public const string Format = "";
    }
    public static class Chaninfo_banned
    {
        public const string DisplayName = "Chaninfo_banned";
        public const string Name = "RPL_CHANINFO_BANNED";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 291;
        public const string Format = "";
    }
    public static class Helpop
    {
        public const string DisplayName = "Helpop";
        public const string Name = "RPL_HELPOP";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 291;
        public const string Format = "";
    }
    public static class Endofcheck
    {
        public const string DisplayName = "Endofcheck";
        public const string Name = "RPL_ENDOFCHECK";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 291;
        public const string Format = "";
    }
    public static class Chaninfo_bans
    {
        public const string DisplayName = "Chaninfo_bans";
        public const string Name = "RPL_CHANINFO_BANS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 292;
        public const string Format = "";
    }
    public static class Helptlr
    {
        public const string DisplayName = "Helptlr";
        public const string Name = "RPL_HELPTLR";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 292;
        public const string Format = "";
    }
    public static class Searchnomatch
    {
        public const string DisplayName = "Searchnomatch";
        public const string Name = "ERR_SEARCHNOMATCH";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 292;
        public const string Format = "";
    }
    public static class Chaninfo_invite
    {
        public const string DisplayName = "Chaninfo_invite";
        public const string Name = "RPL_CHANINFO_INVITE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 293;
        public const string Format = "";
    }
    public static class Helphlp
    {
        public const string DisplayName = "Helphlp";
        public const string Name = "RPL_HELPHLP";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 293;
        public const string Format = "";
    }
    public static class Chaninfo_invites
    {
        public const string DisplayName = "Chaninfo_invites";
        public const string Name = "RPL_CHANINFO_INVITES";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 294;
        public const string Format = "";
    }
    public static class Helpfwd
    {
        public const string DisplayName = "Helpfwd";
        public const string Name = "RPL_HELPFWD";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 294;
        public const string Format = "";
    }
    public static class Chaninfo_kick
    {
        public const string DisplayName = "Chaninfo_kick";
        public const string Name = "RPL_CHANINFO_KICK";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 295;
        public const string Format = "";
    }
    public static class Helpign
    {
        public const string DisplayName = "Helpign";
        public const string Name = "RPL_HELPIGN";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 295;
        public const string Format = "";
    }
    public static class Chaninfo_kicks
    {
        public const string DisplayName = "Chaninfo_kicks";
        public const string Name = "RPL_CHANINFO_KICKS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 296;
        public const string Format = "";
    }
    public static class End_chaninfo
    {
        public const string DisplayName = "End_chaninfo";
        public const string Name = "RPL_END_CHANINFO";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 299;
        public const string Format = "";
    }
    public static class None
    {
        public const string DisplayName = "None";
        public const string Name = "RPL_NONE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 300;
        public const string Format = "";
    }
    public static class Away
    {
        public const string DisplayName = "Away";
        public const string Name = "RPL_AWAY";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 301;
        public const string Format = "<client> <nick> :<message>";
    }
    public static class Userhost
    {
        public const string DisplayName = "Userhost";
        public const string Name = "RPL_USERHOST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 302;
        public const string Format = "<client> :*1<reply> *( ' ' <reply> )";
    }
    public static class Ison
    {
        public const string DisplayName = "Ison";
        public const string Name = "RPL_ISON";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 303;
        public const string Format = "<client> :*1<nick> *( ' ' <nick> )";
    }
    public static class Text
    {
        public const string DisplayName = "Text";
        public const string Name = "RPL_TEXT";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 304;
        public const string Format = "<client> :<text>";
    }
    public static class Unaway
    {
        public const string DisplayName = "Unaway";
        public const string Name = "RPL_UNAWAY";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 305;
        public const string Format = "<client> :<info>";
    }
    public static class Nowaway
    {
        public const string DisplayName = "Nowaway";
        public const string Name = "RPL_NOWAWAY";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 306;
        public const string Format = "<client> :<info>";
    }
    public static class Userip
    {
        public const string DisplayName = "Userip";
        public const string Name = "RPL_USERIP";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 307;
        public const string Format = "";
    }
    public static class Whoisregnick
    {
        public const string DisplayName = "Whoisregnick";
        public const string Name = "RPL_WHOISREGNICK";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 307;
        public const string Format = "";
    }
    public static class Suserhost
    {
        public const string DisplayName = "Suserhost";
        public const string Name = "RPL_SUSERHOST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 307;
        public const string Format = "";
    }
    public static class Notifyaction
    {
        public const string DisplayName = "Notifyaction";
        public const string Name = "RPL_NOTIFYACTION";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 308;
        public const string Format = "";
    }
    public static class Whoisadmin
    {
        public const string DisplayName = "Whoisadmin";
        public const string Name = "RPL_WHOISADMIN";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 308;
        public const string Format = "";
    }
    public static class Rulesstart
    {
        public const string DisplayName = "Rulesstart";
        public const string Name = "RPL_RULESSTART";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 308;
        public const string Format = "";
    }
    public static class Nicktrace
    {
        public const string DisplayName = "Nicktrace";
        public const string Name = "RPL_NICKTRACE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 309;
        public const string Format = "";
    }
    public static class Whoissadmin
    {
        public const string DisplayName = "Whoissadmin";
        public const string Name = "RPL_WHOISSADMIN";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 309;
        public const string Format = "";
    }
    public static class Endofrules
    {
        public const string DisplayName = "Endofrules";
        public const string Name = "RPL_ENDOFRULES";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 309;
        public const string Format = "";
    }
    public static class Whoishelper
    {
        public const string DisplayName = "Whoishelper";
        public const string Name = "RPL_WHOISHELPER";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 309;
        public const string Format = "";
    }
    public static class Whoisservice
    {
        public const string DisplayName = "Whoisservice";
        public const string Name = "RPL_WHOISSERVICE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 309;
        public const string Format = "";
    }
    public static class Whoissvcmsg
    {
        public const string DisplayName = "Whoissvcmsg";
        public const string Name = "RPL_WHOISSVCMSG";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 310;
        public const string Format = "";
    }
    public static class Whoishelpop
    {
        public const string DisplayName = "Whoishelpop";
        public const string Name = "RPL_WHOISHELPOP";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 310;
        public const string Format = "";
    }
    public static class Whoisuser
    {
        public const string DisplayName = "Whoisuser";
        public const string Name = "RPL_WHOISUSER";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 311;
        public const string Format = "<client> <nick> <user> <host> * :<real_name>";
    }
    public static class Whoisserver
    {
        public const string DisplayName = "Whoisserver";
        public const string Name = "RPL_WHOISSERVER";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 312;
        public const string Format = "<client> <nick> <server> :<server_info>";
    }
    public static class Whoisoperator
    {
        public const string DisplayName = "Whoisoperator";
        public const string Name = "RPL_WHOISOPERATOR";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 313;
        public const string Format = "<client> <nick> :<privileges>";
    }
    public static class Whowasuser
    {
        public const string DisplayName = "Whowasuser";
        public const string Name = "RPL_WHOWASUSER";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 314;
        public const string Format = "<client> <nick> <user> <host> * :<real_name>";
    }
    public static class Endofwho
    {
        public const string DisplayName = "Endofwho";
        public const string Name = "RPL_ENDOFWHO";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 315;
        public const string Format = "<client> <name> :<info>";
    }
    public static class Whoisprivdeaf
    {
        public const string DisplayName = "Whoisprivdeaf";
        public const string Name = "RPL_WHOISPRIVDEAF";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 316;
        public const string Format = "";
    }
    public static class Whoischanop
    {
        public const string DisplayName = "Whoischanop";
        public const string Name = "RPL_WHOISCHANOP";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 316;
        public const string Format = "";
    }
    public static class Whoisidle
    {
        public const string DisplayName = "Whoisidle";
        public const string Name = "RPL_WHOISIDLE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 317;
        public const string Format = "<client> <nick> <seconds> :seconds idle";
    }
    public static class Endofwhois
    {
        public const string DisplayName = "Endofwhois";
        public const string Name = "RPL_ENDOFWHOIS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 318;
        public const string Format = "<client> <nick> :<info>";
    }
    public static class Whoischannels
    {
        public const string DisplayName = "Whoischannels";
        public const string Name = "RPL_WHOISCHANNELS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 319;
        public const string Format = "<client> <nick> :*( ( '@' / '+' ) <channel> ' ' )";
    }
    public static class Whoisvirt
    {
        public const string DisplayName = "Whoisvirt";
        public const string Name = "RPL_WHOISVIRT";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 320;
        public const string Format = "";
    }
    public static class Whois_hidden
    {
        public const string DisplayName = "Whois_hidden";
        public const string Name = "RPL_WHOIS_HIDDEN";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 320;
        public const string Format = "";
    }
    public static class Whoisspecial
    {
        public const string DisplayName = "Whoisspecial";
        public const string Name = "RPL_WHOISSPECIAL";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 320;
        public const string Format = "";
    }
    public static class Liststart
    {
        public const string DisplayName = "Liststart";
        public const string Name = "RPL_LISTSTART";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 321;
        public const string Format = "<client> Channels :Users Name";
    }
    public static class List
    {
        public const string DisplayName = "List";
        public const string Name = "RPL_LIST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 322;
        public const string Format = "<client> <channel> <#_visible> :<topic>";
    }
    public static class Listend
    {
        public const string DisplayName = "Listend";
        public const string Name = "RPL_LISTEND";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 323;
        public const string Format = "<client> :<info>";
    }
    public static class Channelmodeis
    {
        public const string DisplayName = "Channelmodeis";
        public const string Name = "RPL_CHANNELMODEIS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 324;
        public const string Format = "<client> <channel> <mode> <mode_params>";
    }
    public static class Uniqopis
    {
        public const string DisplayName = "Uniqopis";
        public const string Name = "RPL_UNIQOPIS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 325;
        public const string Format = "<client> <channel> <nickname>";
    }
    public static class Channelpassis
    {
        public const string DisplayName = "Channelpassis";
        public const string Name = "RPL_CHANNELPASSIS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 325;
        public const string Format = "";
    }
    public static class Whoiswebirc
    {
        public const string DisplayName = "Whoiswebirc";
        public const string Name = "RPL_WHOISWEBIRC";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 325;
        public const string Format = "";
    }
    public static class Channelmlockis
    {
        public const string DisplayName = "Channelmlockis";
        public const string Name = "RPL_CHANNELMLOCKIS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 325;
        public const string Format = "<client> <nick> <channel> <modeletters> :is the current channel mode-lock";
    }
    public static class Nochanpass
    {
        public const string DisplayName = "Nochanpass";
        public const string Name = "RPL_NOCHANPASS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 326;
        public const string Format = "";
    }
    public static class Chpassunknown
    {
        public const string DisplayName = "Chpassunknown";
        public const string Name = "RPL_CHPASSUNKNOWN";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 327;
        public const string Format = "";
    }
    public static class Whoishost
    {
        public const string DisplayName = "Whoishost";
        public const string Name = "RPL_WHOISHOST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 327;
        public const string Format = "";
    }
    public static class Channel_url
    {
        public const string DisplayName = "Channel_url";
        public const string Name = "RPL_CHANNEL_URL";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 328;
        public const string Format = "";
    }
    public static class Creationtime
    {
        public const string DisplayName = "Creationtime";
        public const string Name = "RPL_CREATIONTIME";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 329;
        public const string Format = "";
    }
    public static class Whowas_time
    {
        public const string DisplayName = "Whowas_time";
        public const string Name = "RPL_WHOWAS_TIME";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 330;
        public const string Format = "";
    }
    public static class Whoisaccount
    {
        public const string DisplayName = "Whoisaccount";
        public const string Name = "RPL_WHOISACCOUNT";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 330;
        public const string Format = "<client> <nick> <authname> :<info>";
    }
    public static class Notopic
    {
        public const string DisplayName = "Notopic";
        public const string Name = "RPL_NOTOPIC";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 331;
        public const string Format = "<client> <channel> :<info>";
    }
    public static class Topic
    {
        public const string DisplayName = "Topic";
        public const string Name = "RPL_TOPIC";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 332;
        public const string Format = "<client> <channel> :<topic>";
    }
    public static class Topicwhotime
    {
        public const string DisplayName = "Topicwhotime";
        public const string Name = "RPL_TOPICWHOTIME";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 333;
        public const string Format = "";
    }
    public static class Listusage
    {
        public const string DisplayName = "Listusage";
        public const string Name = "RPL_LISTUSAGE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 334;
        public const string Format = "";
    }
    public static class Commandsyntax
    {
        public const string DisplayName = "Commandsyntax";
        public const string Name = "RPL_COMMANDSYNTAX";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 334;
        public const string Format = "";
    }
    public static class Listsyntax
    {
        public const string DisplayName = "Listsyntax";
        public const string Name = "RPL_LISTSYNTAX";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 334;
        public const string Format = "";
    }
    public static class Whoisbot
    {
        public const string DisplayName = "Whoisbot";
        public const string Name = "RPL_WHOISBOT";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 335;
        public const string Format = "";
    }
    public static class Whoistext
    {
        public const string DisplayName = "Whoistext";
        public const string Name = "RPL_WHOISTEXT";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 335;
        public const string Format = "";
    }
    public static class Whoisaccountonly
    {
        public const string DisplayName = "Whoisaccountonly";
        public const string Name = "RPL_WHOISACCOUNTONLY";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 335;
        public const string Format = "";
    }
    public static class Invitelist
    {
        public const string DisplayName = "Invitelist";
        public const string Name = "RPL_INVITELIST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 336;
        public const string Format = "<client> :<channel>";
    }
    public static class Endofinvitelist
    {
        public const string DisplayName = "Endofinvitelist";
        public const string Name = "RPL_ENDOFINVITELIST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 337;
        public const string Format = "<client> :End of /INVITE list.";
    }
    public static class Chanpassok
    {
        public const string DisplayName = "Chanpassok";
        public const string Name = "RPL_CHANPASSOK";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 338;
        public const string Format = "";
    }
    public static class Whoisactually
    {
        public const string DisplayName = "Whoisactually";
        public const string Name = "RPL_WHOISACTUALLY";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 338;
        public const string Format = "";
    }
    public static class Badchanpass
    {
        public const string DisplayName = "Badchanpass";
        public const string Name = "RPL_BADCHANPASS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 339;
        public const string Format = "";
    }
    public static class Whoismarks
    {
        public const string DisplayName = "Whoismarks";
        public const string Name = "RPL_WHOISMARKS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 339;
        public const string Format = "";
    }
    public static class Inviting
    {
        public const string DisplayName = "Inviting";
        public const string Name = "RPL_INVITING";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 341;
        public const string Format = "<client> <nick> <channel>";
    }
    public static class Summoning
    {
        public const string DisplayName = "Summoning";
        public const string Name = "RPL_SUMMONING";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 342;
        public const string Format = "<client> <user> :<info>";
    }
    public static class Whoiskill
    {
        public const string DisplayName = "Whoiskill";
        public const string Name = "RPL_WHOISKILL";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 343;
        public const string Format = "";
    }
    public static class Whoiscountry
    {
        public const string DisplayName = "Whoiscountry";
        public const string Name = "RPL_WHOISCOUNTRY";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 344;
        public const string Format = "<client> <nick> :is connected from <country> <country code>";
    }
    public static class Reoplist
    {
        public const string DisplayName = "Reoplist";
        public const string Name = "RPL_REOPLIST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 344;
        public const string Format = "<client> <channel> <mask>";
    }
    public static class Invited
    {
        public const string DisplayName = "Invited";
        public const string Name = "RPL_INVITED";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 345;
        public const string Format = "<client> <channel> <user being invited> <user issuing invite> :<user being invited> has been invited by <user issuing invite>";
    }
    public static class Endofreoplist
    {
        public const string DisplayName = "Endofreoplist";
        public const string Name = "RPL_ENDOFREOPLIST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 345;
        public const string Format = "<client> <channel>: :End of Channel Reop List";
    }
    public static class Exceptlist
    {
        public const string DisplayName = "Exceptlist";
        public const string Name = "RPL_EXCEPTLIST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 348;
        public const string Format = "<client> <channel> <exceptionmask> [<who> <set-ts>]";
    }
    public static class Endofexceptlist
    {
        public const string DisplayName = "Endofexceptlist";
        public const string Name = "RPL_ENDOFEXCEPTLIST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 349;
        public const string Format = "<client> <channel> :<info>";
    }
    public static class Whoisgateway
    {
        public const string DisplayName = "Whoisgateway";
        public const string Name = "RPL_WHOISGATEWAY";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 350;
        public const string Format = "<client> <real host> <real ip> :is connecting via {the <name> WebIRC, an ident} gateway";
    }
    public static class Version
    {
        public const string DisplayName = "Version";
        public const string Name = "RPL_VERSION";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 351;
        public const string Format = "<client> <version> <server> :<comments>";
    }
    public static class Whoreply
    {
        public const string DisplayName = "Whoreply";
        public const string Name = "RPL_WHOREPLY";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 352;
        public const string Format = "<client> <channel> <user> <host> <server> <nick> <H|G>[*][@|+] :<hopcount> <real_name>";
    }
    public static class Namreply
    {
        public const string DisplayName = "Namreply";
        public const string Name = "RPL_NAMREPLY";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 353;
        public const string Format = "<client> ( '=' / '*' / '@' ) <channel> ' ' : [ '@' / '+' ] <nick> *( ' ' [ '@' / '+' ] <nick> )";
    }
    public static class Whospcrpl
    {
        public const string DisplayName = "Whospcrpl";
        public const string Name = "RPL_WHOSPCRPL";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 354;
        public const string Format = "";
    }
    public static class Namreply_
    {
        public const string DisplayName = "Namreply_";
        public const string Name = "RPL_NAMREPLY_";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 355;
        public const string Format = "<client> ( '=' / '*' / '@' ) <channel> ' ' : [ '@' / '+' ] <nick> *( ' ' [ '@' / '+' ] <nick> )";
    }
    public static class Whowasreal
    {
        public const string DisplayName = "Whowasreal";
        public const string Name = "RPL_WHOWASREAL";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 360;
        public const string Format = "";
    }
    public static class Killdone
    {
        public const string DisplayName = "Killdone";
        public const string Name = "RPL_KILLDONE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 361;
        public const string Format = "";
    }
    public static class Closing
    {
        public const string DisplayName = "Closing";
        public const string Name = "RPL_CLOSING";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 362;
        public const string Format = "";
    }
    public static class Closeend
    {
        public const string DisplayName = "Closeend";
        public const string Name = "RPL_CLOSEEND";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 363;
        public const string Format = "";
    }
    public static class Links
    {
        public const string DisplayName = "Links";
        public const string Name = "RPL_LINKS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 364;
        public const string Format = "<client> <mask> <server> :<hopcount> <server_info>";
    }
    public static class Endoflinks
    {
        public const string DisplayName = "Endoflinks";
        public const string Name = "RPL_ENDOFLINKS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 365;
        public const string Format = "<client> <mask> :<info>";
    }
    public static class Endofnames
    {
        public const string DisplayName = "Endofnames";
        public const string Name = "RPL_ENDOFNAMES";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 366;
        public const string Format = "<client> <channel> :<info>";
    }
    public static class Banlist
    {
        public const string DisplayName = "Banlist";
        public const string Name = "RPL_BANLIST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 367;
        public const string Format = "<client> <channel> <banid> [[<setter> <time_left>|<time_left> :<reason>]]";
    }
    public static class Endofbanlist
    {
        public const string DisplayName = "Endofbanlist";
        public const string Name = "RPL_ENDOFBANLIST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 368;
        public const string Format = "<client> <channel> :<info>";
    }
    public static class Endofwhowas
    {
        public const string DisplayName = "Endofwhowas";
        public const string Name = "RPL_ENDOFWHOWAS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 369;
        public const string Format = "<client> <nick> :<info>";
    }
    public static class Info
    {
        public const string DisplayName = "Info";
        public const string Name = "RPL_INFO";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 371;
        public const string Format = "<client> :<string>";
    }
    public static class Motd
    {
        public const string DisplayName = "Motd";
        public const string Name = "RPL_MOTD";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 372;
        public const string Format = "<client> :- <string>";
    }
    public static class Infostart
    {
        public const string DisplayName = "Infostart";
        public const string Name = "RPL_INFOSTART";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 373;
        public const string Format = "";
    }
    public static class Endofinfo
    {
        public const string DisplayName = "Endofinfo";
        public const string Name = "RPL_ENDOFINFO";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 374;
        public const string Format = "<client> :<info>";
    }
    public static class Motdstart
    {
        public const string DisplayName = "Motdstart";
        public const string Name = "RPL_MOTDSTART";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 375;
        public const string Format = "<client> :- <server> Message of the day -";
    }
    public static class Endofmotd
    {
        public const string DisplayName = "Endofmotd";
        public const string Name = "RPL_ENDOFMOTD";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 376;
        public const string Format = "<client> :<info>";
    }
    public static class Kickexpired
    {
        public const string DisplayName = "Kickexpired";
        public const string Name = "RPL_KICKEXPIRED";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 377;
        public const string Format = "";
    }
    public static class Spam
    {
        public const string DisplayName = "Spam";
        public const string Name = "RPL_SPAM";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 377;
        public const string Format = "<client> :<text>";
    }
    public static class Banexpired
    {
        public const string DisplayName = "Banexpired";
        public const string Name = "RPL_BANEXPIRED";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 378;
        public const string Format = "";
    }
    public static class Kicklinked
    {
        public const string DisplayName = "Kicklinked";
        public const string Name = "RPL_KICKLINKED";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 379;
        public const string Format = "";
    }
    public static class Whoismodes
    {
        public const string DisplayName = "Whoismodes";
        public const string Name = "RPL_WHOISMODES";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 379;
        public const string Format = "";
    }
    public static class Whowasip
    {
        public const string DisplayName = "Whowasip";
        public const string Name = "RPL_WHOWASIP";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 379;
        public const string Format = "<client> <nick> :was connecting from <host>";
    }
    public static class Banlinked
    {
        public const string DisplayName = "Banlinked";
        public const string Name = "RPL_BANLINKED";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 380;
        public const string Format = "";
    }
    public static class Yourhelper
    {
        public const string DisplayName = "Yourhelper";
        public const string Name = "RPL_YOURHELPER";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 380;
        public const string Format = "";
    }
    public static class Youreoper
    {
        public const string DisplayName = "Youreoper";
        public const string Name = "RPL_YOUREOPER";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 381;
        public const string Format = "<client> :<info>";
    }
    public static class Rehashing
    {
        public const string DisplayName = "Rehashing";
        public const string Name = "RPL_REHASHING";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 382;
        public const string Format = "<client> <config_file> :<info>";
    }
    public static class Youreservice
    {
        public const string DisplayName = "Youreservice";
        public const string Name = "RPL_YOURESERVICE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 383;
        public const string Format = "<client> :You are service <service_name>";
    }
    public static class Myportis
    {
        public const string DisplayName = "Myportis";
        public const string Name = "RPL_MYPORTIS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 384;
        public const string Format = "";
    }
    public static class Notoperanymore
    {
        public const string DisplayName = "Notoperanymore";
        public const string Name = "RPL_NOTOPERANYMORE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 385;
        public const string Format = "";
    }
    public static class Qlist
    {
        public const string DisplayName = "Qlist";
        public const string Name = "RPL_QLIST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 386;
        public const string Format = "";
    }
    public static class Ircops
    {
        public const string DisplayName = "Ircops";
        public const string Name = "RPL_IRCOPS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 386;
        public const string Format = "";
    }
    public static class Ircopsheader
    {
        public const string DisplayName = "Ircopsheader";
        public const string Name = "RPL_IRCOPSHEADER";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 386;
        public const string Format = "";
    }
    public static class Rsachallenge
    {
        public const string DisplayName = "Rsachallenge";
        public const string Name = "RPL_RSACHALLENGE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 386;
        public const string Format = ":*";
    }
    public static class Endofqlist
    {
        public const string DisplayName = "Endofqlist";
        public const string Name = "RPL_ENDOFQLIST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 387;
        public const string Format = "";
    }
    public static class Endofircops
    {
        public const string DisplayName = "Endofircops";
        public const string Name = "RPL_ENDOFIRCOPS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 387;
        public const string Format = "";
    }
    public static class Time
    {
        public const string DisplayName = "Time";
        public const string Name = "RPL_TIME";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 391;
        public const string Format = "<client> <server> :<time string>";
    }
    public static class Usersstart
    {
        public const string DisplayName = "Usersstart";
        public const string Name = "RPL_USERSSTART";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 392;
        public const string Format = "<client> :UserID Terminal Host";
    }
    public static class Users
    {
        public const string DisplayName = "Users";
        public const string Name = "RPL_USERS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 393;
        public const string Format = "<client> :<username> <ttyline> <hostname>";
    }
    public static class Endofusers
    {
        public const string DisplayName = "Endofusers";
        public const string Name = "RPL_ENDOFUSERS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 394;
        public const string Format = "<client> :<info>";
    }
    public static class Nousers
    {
        public const string DisplayName = "Nousers";
        public const string Name = "RPL_NOUSERS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 395;
        public const string Format = "<client> :<info>";
    }
    public static class Visiblehost
    {
        public const string DisplayName = "Visiblehost";
        public const string Name = "RPL_VISIBLEHOST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 396;
        public const string Format = "<client> <hostname> :is now your visible host";
    }
    public static class Clones
    {
        public const string DisplayName = "Clones";
        public const string Name = "RPL_CLONES";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 399;
        public const string Format = "<client> <local-count> <global-count> <cidr-range>";
    }
    public static class Unknownerror
    {
        public const string DisplayName = "Unknownerror";
        public const string Name = "ERR_UNKNOWNERROR";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 400;
        public const string Format = "<client> <command> [<?>] :<info>";
    }
    public static class Nosuchnick
    {
        public const string DisplayName = "Nosuchnick";
        public const string Name = "ERR_NOSUCHNICK";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 401;
        public const string Format = "<client> <nick> :<reason>";
    }
    public static class Nosuchserver
    {
        public const string DisplayName = "Nosuchserver";
        public const string Name = "ERR_NOSUCHSERVER";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 402;
        public const string Format = "<client> <server> :<reason>";
    }
    public static class Nosuchchannel
    {
        public const string DisplayName = "Nosuchchannel";
        public const string Name = "ERR_NOSUCHCHANNEL";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 403;
        public const string Format = "<client> <channel> :<reason>";
    }
    public static class Cannotsendtochan
    {
        public const string DisplayName = "Cannotsendtochan";
        public const string Name = "ERR_CANNOTSENDTOCHAN";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 404;
        public const string Format = "<client> <channel> :<reason>";
    }
    public static class Toomanychannels
    {
        public const string DisplayName = "Toomanychannels";
        public const string Name = "ERR_TOOMANYCHANNELS";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 405;
        public const string Format = "<client> <channel> :<reason>";
    }
    public static class Wasnosuchnick
    {
        public const string DisplayName = "Wasnosuchnick";
        public const string Name = "ERR_WASNOSUCHNICK";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 406;
        public const string Format = "<client> <nick> :<reason>";
    }
    public static class Toomanytargets
    {
        public const string DisplayName = "Toomanytargets";
        public const string Name = "ERR_TOOMANYTARGETS";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 407;
        public const string Format = "<client> <target> :<reason>";
    }
    public static class Nosuchservice
    {
        public const string DisplayName = "Nosuchservice";
        public const string Name = "ERR_NOSUCHSERVICE";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 408;
        public const string Format = "<client> <service_name> :<reason>";
    }
    public static class Nocolorsonchan
    {
        public const string DisplayName = "Nocolorsonchan";
        public const string Name = "ERR_NOCOLORSONCHAN";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 408;
        public const string Format = "";
    }
    public static class Noctrlsonchan
    {
        public const string DisplayName = "Noctrlsonchan";
        public const string Name = "ERR_NOCTRLSONCHAN";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 408;
        public const string Format = "<client> <channel> :You cannot use control codes on this channel. Not sent: <text>";
    }
    public static class Noorigin
    {
        public const string DisplayName = "Noorigin";
        public const string Name = "ERR_NOORIGIN";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 409;
        public const string Format = "<client> :<reason>";
    }
    public static class Invalidcapcmd
    {
        public const string DisplayName = "Invalidcapcmd";
        public const string Name = "ERR_INVALIDCAPCMD";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 410;
        public const string Format = "<client> <badcmd> :Invalid CAP subcommand";
    }
    public static class Norecipient
    {
        public const string DisplayName = "Norecipient";
        public const string Name = "ERR_NORECIPIENT";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 411;
        public const string Format = "<client> :<reason>";
    }
    public static class Notexttosend
    {
        public const string DisplayName = "Notexttosend";
        public const string Name = "ERR_NOTEXTTOSEND";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 412;
        public const string Format = "<client> :<reason>";
    }
    public static class Notoplevel
    {
        public const string DisplayName = "Notoplevel";
        public const string Name = "ERR_NOTOPLEVEL";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 413;
        public const string Format = "<client> <mask> :<reason>";
    }
    public static class Wildtoplevel
    {
        public const string DisplayName = "Wildtoplevel";
        public const string Name = "ERR_WILDTOPLEVEL";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 414;
        public const string Format = "<client> <mask> :<reason>";
    }
    public static class Badmask
    {
        public const string DisplayName = "Badmask";
        public const string Name = "ERR_BADMASK";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 415;
        public const string Format = "<client> <mask> :<reason>";
    }
    public static class Toomanymatches
    {
        public const string DisplayName = "Toomanymatches";
        public const string Name = "ERR_TOOMANYMATCHES";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 416;
        public const string Format = "<client> <command> [<mask>] :<info>";
    }
    public static class Querytoolong
    {
        public const string DisplayName = "Querytoolong";
        public const string Name = "ERR_QUERYTOOLONG";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 416;
        public const string Format = "";
    }
    public static class Inputtoolong
    {
        public const string DisplayName = "Inputtoolong";
        public const string Name = "ERR_INPUTTOOLONG";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 417;
        public const string Format = "";
    }
    public static class Lengthtruncated
    {
        public const string DisplayName = "Lengthtruncated";
        public const string Name = "ERR_LENGTHTRUNCATED";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 419;
        public const string Format = "";
    }
    public static class Ambiguouscommand
    {
        public const string DisplayName = "Ambiguouscommand";
        public const string Name = "ERR_AMBIGUOUSCOMMAND";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 420;
        public const string Format = "<client> :Ambiguous abbreviation";
    }
    public static class Unknowncommand
    {
        public const string DisplayName = "Unknowncommand";
        public const string Name = "ERR_UNKNOWNCOMMAND";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 421;
        public const string Format = "<client> <command> :<reason>";
    }
    public static class Nomotd
    {
        public const string DisplayName = "Nomotd";
        public const string Name = "ERR_NOMOTD";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 422;
        public const string Format = "<client> :<reason>";
    }
    public static class Noadmininfo
    {
        public const string DisplayName = "Noadmininfo";
        public const string Name = "ERR_NOADMININFO";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 423;
        public const string Format = "<client> <server> :<reason>";
    }
    public static class Fileerror
    {
        public const string DisplayName = "Fileerror";
        public const string Name = "ERR_FILEERROR";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 424;
        public const string Format = "<client> :<reason>";
    }
    public static class Noopermotd
    {
        public const string DisplayName = "Noopermotd";
        public const string Name = "ERR_NOOPERMOTD";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 425;
        public const string Format = "";
    }
    public static class Toomanyaway
    {
        public const string DisplayName = "Toomanyaway";
        public const string Name = "ERR_TOOMANYAWAY";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 429;
        public const string Format = "";
    }
    public static class Eventnickchange
    {
        public const string DisplayName = "Eventnickchange";
        public const string Name = "ERR_EVENTNICKCHANGE";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 430;
        public const string Format = "";
    }
    public static class Nonicknamegiven
    {
        public const string DisplayName = "Nonicknamegiven";
        public const string Name = "ERR_NONICKNAMEGIVEN";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 431;
        public const string Format = "<client> :<reason>";
    }
    public static class Erroneusnickname
    {
        public const string DisplayName = "Erroneusnickname";
        public const string Name = "ERR_ERRONEUSNICKNAME";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 432;
        public const string Format = "<client> <nick> :<reason>";
    }
    public static class Nicknameinuse
    {
        public const string DisplayName = "Nicknameinuse";
        public const string Name = "ERR_NICKNAMEINUSE";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 433;
        public const string Format = "<client> <nick> :<reason>";
    }
    public static class Servicenameinuse
    {
        public const string DisplayName = "Servicenameinuse";
        public const string Name = "ERR_SERVICENAMEINUSE";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 434;
        public const string Format = "";
    }
    public static class Norules
    {
        public const string DisplayName = "Norules";
        public const string Name = "ERR_NORULES";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 434;
        public const string Format = "";
    }
    public static class Serviceconfused
    {
        public const string DisplayName = "Serviceconfused";
        public const string Name = "ERR_SERVICECONFUSED";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 435;
        public const string Format = "";
    }
    public static class Banonchan
    {
        public const string DisplayName = "Banonchan";
        public const string Name = "ERR_BANONCHAN";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 435;
        public const string Format = "";
    }
    public static class Nickcollision
    {
        public const string DisplayName = "Nickcollision";
        public const string Name = "ERR_NICKCOLLISION";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 436;
        public const string Format = "<nick> :<reason>";
    }
    public static class Unavailresource
    {
        public const string DisplayName = "Unavailresource";
        public const string Name = "ERR_UNAVAILRESOURCE";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 437;
        public const string Format = "<client> <nick/channel/service> :<reason>";
    }
    public static class Bannickchange
    {
        public const string DisplayName = "Bannickchange";
        public const string Name = "ERR_BANNICKCHANGE";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 437;
        public const string Format = "";
    }
    public static class Nicktoofast
    {
        public const string DisplayName = "Nicktoofast";
        public const string Name = "ERR_NICKTOOFAST";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 438;
        public const string Format = "";
    }
    public static class Dead
    {
        public const string DisplayName = "Dead";
        public const string Name = "ERR_DEAD";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 438;
        public const string Format = "";
    }
    public static class Targettoofast
    {
        public const string DisplayName = "Targettoofast";
        public const string Name = "ERR_TARGETTOOFAST";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 439;
        public const string Format = "";
    }
    public static class Servicesdown
    {
        public const string DisplayName = "Servicesdown";
        public const string Name = "ERR_SERVICESDOWN";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 440;
        public const string Format = "";
    }
    public static class Usernotinchannel
    {
        public const string DisplayName = "Usernotinchannel";
        public const string Name = "ERR_USERNOTINCHANNEL";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 441;
        public const string Format = "<client> <nick> <channel> :<reason>";
    }
    public static class Notonchannel
    {
        public const string DisplayName = "Notonchannel";
        public const string Name = "ERR_NOTONCHANNEL";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 442;
        public const string Format = "<client> <channel> :<reason>";
    }
    public static class Useronchannel
    {
        public const string DisplayName = "Useronchannel";
        public const string Name = "ERR_USERONCHANNEL";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 443;
        public const string Format = "<client> <nick> <channel> [:<reason>]";
    }
    public static class Nologin
    {
        public const string DisplayName = "Nologin";
        public const string Name = "ERR_NOLOGIN";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 444;
        public const string Format = "<client> <user> :<reason>";
    }
    public static class Summondisabled
    {
        public const string DisplayName = "Summondisabled";
        public const string Name = "ERR_SUMMONDISABLED";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 445;
        public const string Format = "<client> :<reason>";
    }
    public static class Usersdisabled
    {
        public const string DisplayName = "Usersdisabled";
        public const string Name = "ERR_USERSDISABLED";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 446;
        public const string Format = "<client> :<reason>";
    }
    public static class Nonickchange
    {
        public const string DisplayName = "Nonickchange";
        public const string Name = "ERR_NONICKCHANGE";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 447;
        public const string Format = "";
    }
    public static class Forbiddenchannel
    {
        public const string DisplayName = "Forbiddenchannel";
        public const string Name = "ERR_FORBIDDENCHANNEL";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 448;
        public const string Format = "<channel> :Channel is forbidden: <reason>";
    }
    public static class Notimplemented
    {
        public const string DisplayName = "Notimplemented";
        public const string Name = "ERR_NOTIMPLEMENTED";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 449;
        public const string Format = "Unspecified";
    }
    public static class Notregistered
    {
        public const string DisplayName = "Notregistered";
        public const string Name = "ERR_NOTREGISTERED";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 451;
        public const string Format = "<client> :<reason>";
    }
    public static class Idcollision
    {
        public const string DisplayName = "Idcollision";
        public const string Name = "ERR_IDCOLLISION";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 452;
        public const string Format = "";
    }
    public static class Nicklost
    {
        public const string DisplayName = "Nicklost";
        public const string Name = "ERR_NICKLOST";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 453;
        public const string Format = "";
    }
    public static class Hostilename
    {
        public const string DisplayName = "Hostilename";
        public const string Name = "ERR_HOSTILENAME";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 455;
        public const string Format = "";
    }
    public static class Acceptfull
    {
        public const string DisplayName = "Acceptfull";
        public const string Name = "ERR_ACCEPTFULL";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 456;
        public const string Format = "";
    }
    public static class Acceptexist
    {
        public const string DisplayName = "Acceptexist";
        public const string Name = "ERR_ACCEPTEXIST";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 457;
        public const string Format = "";
    }
    public static class Acceptnot
    {
        public const string DisplayName = "Acceptnot";
        public const string Name = "ERR_ACCEPTNOT";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 458;
        public const string Format = "";
    }
    public static class Nohiding
    {
        public const string DisplayName = "Nohiding";
        public const string Name = "ERR_NOHIDING";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 459;
        public const string Format = "";
    }
    public static class Notforhalfops
    {
        public const string DisplayName = "Notforhalfops";
        public const string Name = "ERR_NOTFORHALFOPS";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 460;
        public const string Format = "";
    }
    public static class Needmoreparams
    {
        public const string DisplayName = "Needmoreparams";
        public const string Name = "ERR_NEEDMOREPARAMS";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 461;
        public const string Format = "<client> <command> :<reason>";
    }
    public static class Alreadyregistered
    {
        public const string DisplayName = "Alreadyregistered";
        public const string Name = "ERR_ALREADYREGISTERED";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 462;
        public const string Format = "<client> :<reason>";
    }
    public static class Nopermforhost
    {
        public const string DisplayName = "Nopermforhost";
        public const string Name = "ERR_NOPERMFORHOST";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 463;
        public const string Format = "<client> :<reason>";
    }
    public static class Passwdmismatch
    {
        public const string DisplayName = "Passwdmismatch";
        public const string Name = "ERR_PASSWDMISMATCH";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 464;
        public const string Format = "<client> :<reason>";
    }
    public static class Yourebannedcreep
    {
        public const string DisplayName = "Yourebannedcreep";
        public const string Name = "ERR_YOUREBANNEDCREEP";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 465;
        public const string Format = "<client> :<reason>";
    }
    public static class Youwillbebanned
    {
        public const string DisplayName = "Youwillbebanned";
        public const string Name = "ERR_YOUWILLBEBANNED";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 466;
        public const string Format = "";
    }
    public static class Keyset
    {
        public const string DisplayName = "Keyset";
        public const string Name = "ERR_KEYSET";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 467;
        public const string Format = "<client> <channel> :<reason>";
    }
    public static class Invalidusername
    {
        public const string DisplayName = "Invalidusername";
        public const string Name = "ERR_INVALIDUSERNAME";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 468;
        public const string Format = "";
    }
    public static class Onlyserverscanchange
    {
        public const string DisplayName = "Onlyserverscanchange";
        public const string Name = "ERR_ONLYSERVERSCANCHANGE";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 468;
        public const string Format = "";
    }
    public static class Nocodepage
    {
        public const string DisplayName = "Nocodepage";
        public const string Name = "ERR_NOCODEPAGE";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 468;
        public const string Format = "";
    }
    public static class Linkset
    {
        public const string DisplayName = "Linkset";
        public const string Name = "ERR_LINKSET";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 469;
        public const string Format = "";
    }
    public static class Linkchannel
    {
        public const string DisplayName = "Linkchannel";
        public const string Name = "ERR_LINKCHANNEL";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 470;
        public const string Format = "";
    }
    public static class Kickedfromchan
    {
        public const string DisplayName = "Kickedfromchan";
        public const string Name = "ERR_KICKEDFROMCHAN";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 470;
        public const string Format = "";
    }
    public static class Sevenbit
    {
        public const string DisplayName = "7bit";
        public const string Name = "ERR_7BIT";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 470;
        public const string Format = "";
    }
    public static class Channelisfull
    {
        public const string DisplayName = "Channelisfull";
        public const string Name = "ERR_CHANNELISFULL";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 471;
        public const string Format = "<client> <channel> :<reason>";
    }
    public static class Unknownmode
    {
        public const string DisplayName = "Unknownmode";
        public const string Name = "ERR_UNKNOWNMODE";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 472;
        public const string Format = "<client> <char> :<reason>";
    }
    public static class Inviteonlychan
    {
        public const string DisplayName = "Inviteonlychan";
        public const string Name = "ERR_INVITEONLYCHAN";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 473;
        public const string Format = "<client> <channel> :<reason>";
    }
    public static class Bannedfromchan
    {
        public const string DisplayName = "Bannedfromchan";
        public const string Name = "ERR_BANNEDFROMCHAN";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 474;
        public const string Format = "<client> <channel> :<reason>";
    }
    public static class Badchannelkey
    {
        public const string DisplayName = "Badchannelkey";
        public const string Name = "ERR_BADCHANNELKEY";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 475;
        public const string Format = "<client> <channel> :<reason>";
    }
    public static class Badchanmask
    {
        public const string DisplayName = "Badchanmask";
        public const string Name = "ERR_BADCHANMASK";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 476;
        public const string Format = "<client> <channel> :<reason>";
    }
    public static class Nochanmodes
    {
        public const string DisplayName = "Nochanmodes";
        public const string Name = "ERR_NOCHANMODES";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 477;
        public const string Format = "<client> <channel> :<reason>";
    }
    public static class Needreggednick
    {
        public const string DisplayName = "Needreggednick";
        public const string Name = "ERR_NEEDREGGEDNICK";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 477;
        public const string Format = "";
    }
    public static class Banlistfull
    {
        public const string DisplayName = "Banlistfull";
        public const string Name = "ERR_BANLISTFULL";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 478;
        public const string Format = "<client> <channel> [char] :<reason>";
    }
    public static class Badchanname
    {
        public const string DisplayName = "Badchanname";
        public const string Name = "ERR_BADCHANNAME";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 479;
        public const string Format = "<client> <channel> :<reason>";
    }
    public static class Linkfail
    {
        public const string DisplayName = "Linkfail";
        public const string Name = "ERR_LINKFAIL";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 479;
        public const string Format = "";
    }
    public static class Nocolor
    {
        public const string DisplayName = "Nocolor";
        public const string Name = "ERR_NOCOLOR";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 479;
        public const string Format = "";
    }
    public static class Nouline
    {
        public const string DisplayName = "Nouline";
        public const string Name = "ERR_NOULINE";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 480;
        public const string Format = "";
    }
    public static class Cannotknock
    {
        public const string DisplayName = "Cannotknock";
        public const string Name = "ERR_CANNOTKNOCK";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 480;
        public const string Format = "";
    }
    public static class Throttle
    {
        public const string DisplayName = "Throttle";
        public const string Name = "ERR_THROTTLE";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 480;
        public const string Format = "<nick> <channel> :Cannot join channel";
    }
    public static class Sslonlychan
    {
        public const string DisplayName = "Sslonlychan";
        public const string Name = "ERR_SSLONLYCHAN";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 480;
        public const string Format = "";
    }
    public static class Nowallop
    {
        public const string DisplayName = "Nowallop";
        public const string Name = "ERR_NOWALLOP";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 480;
        public const string Format = "";
    }
    public static class Noprivileges
    {
        public const string DisplayName = "Noprivileges";
        public const string Name = "ERR_NOPRIVILEGES";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 481;
        public const string Format = "<client> :<reason>";
    }
    public static class Chanoprivsneeded
    {
        public const string DisplayName = "Chanoprivsneeded";
        public const string Name = "ERR_CHANOPRIVSNEEDED";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 482;
        public const string Format = "<client> <channel> :<reason>";
    }
    public static class Cantkillserver
    {
        public const string DisplayName = "Cantkillserver";
        public const string Name = "ERR_CANTKILLSERVER";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 483;
        public const string Format = "< client > :< reason >";
    }
    public static class Restricted
    {
        public const string DisplayName = "Restricted";
        public const string Name = "ERR_RESTRICTED";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 484;
        public const string Format = "< client > :< reason >";
    }
    public static class Ischanservice
    {
        public const string DisplayName = "Ischanservice";
        public const string Name = "ERR_ISCHANSERVICE";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 484;
        public const string Format = "";
    }
    public static class Desync
    {
        public const string DisplayName = "Desync";
        public const string Name = "ERR_DESYNC";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 484;
        public const string Format = "";
    }
    public static class Attackdeny
    {
        public const string DisplayName = "Attackdeny";
        public const string Name = "ERR_ATTACKDENY";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 484;
        public const string Format = "";
    }
    public static class Uniqoprivsneeded
    {
        public const string DisplayName = "Uniqoprivsneeded";
        public const string Name = "ERR_UNIQOPRIVSNEEDED";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 485;
        public const string Format = "< client > :< reason >";
    }
    public static class Killdeny
    {
        public const string DisplayName = "Killdeny";
        public const string Name = "ERR_KILLDENY";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 485;
        public const string Format = "";
    }
    public static class Cantkickadmin
    {
        public const string DisplayName = "Cantkickadmin";
        public const string Name = "ERR_CANTKICKADMIN";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 485;
        public const string Format = "";
    }
    public static class Isrealservice
    {
        public const string DisplayName = "Isrealservice";
        public const string Name = "ERR_ISREALSERVICE";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 485;
        public const string Format = "";
    }
    public static class Chanbanreason
    {
        public const string DisplayName = "Chanbanreason";
        public const string Name = "ERR_CHANBANREASON";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 485;
        public const string Format = "< client > < channel > :Cannot join channel(< reason >)";
    }
    public static class Bannednick
    {
        public const string DisplayName = "Bannednick";
        public const string Name = "ERR_BANNEDNICK";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 485;
        public const string Format = "";
    }
    public static class Nononreg
    {
        public const string DisplayName = "Nononreg";
        public const string Name = "ERR_NONONREG";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 486;
        public const string Format = "";
    }
    public static class Rlined
    {
        public const string DisplayName = "Rlined";
        public const string Name = "ERR_RLINED";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 486;
        public const string Format = "";
    }
    public static class Htmdisabled
    {
        public const string DisplayName = "Htmdisabled";
        public const string Name = "ERR_HTMDISABLED";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 486;
        public const string Format = "";
    }
    public static class Chantoorecent
    {
        public const string DisplayName = "Chantoorecent";
        public const string Name = "ERR_CHANTOORECENT";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 487;
        public const string Format = "";
    }
    public static class Msgservices
    {
        public const string DisplayName = "Msgservices";
        public const string Name = "ERR_MSGSERVICES";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 487;
        public const string Format = "";
    }
    public static class Notforusers
    {
        public const string DisplayName = "Notforusers";
        public const string Name = "ERR_NOTFORUSERS";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 487;
        public const string Format = "";
    }
    public static class Nononssl
    {
        public const string DisplayName = "Nononssl";
        public const string Name = "ERR_NONONSSL";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 487;
        public const string Format = "< target user > :You must be connected using SSL/ TLS to message this user";
    }
    public static class Tslesschan
    {
        public const string DisplayName = "Tslesschan";
        public const string Name = "ERR_TSLESSCHAN";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 488;
        public const string Format = "";
    }
    public static class Nossl
    {
        public const string DisplayName = "Nossl";
        public const string Name = "ERR_NOSSL";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 488;
        public const string Format = "<client> <channel> :SSL Only channel (+S), You must connect using SSL to join this channel.";
    }
    public static class Secureonlychan
    {
        public const string DisplayName = "Secureonlychan";
        public const string Name = "ERR_SECUREONLYCHAN";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 489;
        public const string Format = "";
    }
    public static class Voiceneeded
    {
        public const string DisplayName = "Voiceneeded";
        public const string Name = "ERR_VOICENEEDED";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 489;
        public const string Format = "";
    }
    public static class Allmustssl
    {
        public const string DisplayName = "Allmustssl";
        public const string Name = "ERR_ALLMUSTSSL";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 490;
        public const string Format = "< client > < channel > :all members of the channel must be connected via SSL";
    }
    public static class Noswear
    {
        public const string DisplayName = "Noswear";
        public const string Name = "ERR_NOSWEAR";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 490;
        public const string Format = "< client > :< nick > does not accept private messages containing swearing.";
    }
    public static class Nooperhost
    {
        public const string DisplayName = "Nooperhost";
        public const string Name = "ERR_NOOPERHOST";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 491;
        public const string Format = "<client> :<reason>";
    }
    public static class Noservicehost
    {
        public const string DisplayName = "Noservicehost";
        public const string Name = "ERR_NOSERVICEHOST";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 492;
        public const string Format = "";
    }
    public static class Noctcp
    {
        public const string DisplayName = "Noctcp";
        public const string Name = "ERR_NOCTCP";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 492;
        public const string Format = "<client> :You cannot send CTCPs to this channel. Not sent: <message>";
    }
    public static class Cannotsendtouser
    {
        public const string DisplayName = "Cannotsendtouser";
        public const string Name = "ERR_CANNOTSENDTOUSER";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 492;
        public const string Format = "<client> :Cannot send to user <nick> (<reason>)";
    }
    public static class Nosharedchan
    {
        public const string DisplayName = "Nosharedchan";
        public const string Name = "ERR_NOSHAREDCHAN";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 493;
        public const string Format = "<client> :You cannot message that person because you do not share a common channel with them.";
    }
    public static class Nofeature
    {
        public const string DisplayName = "Nofeature";
        public const string Name = "ERR_NOFEATURE";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 493;
        public const string Format = "";
    }
    public static class Badfeatvalue
    {
        public const string DisplayName = "Badfeatvalue";
        public const string Name = "ERR_BADFEATVALUE";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 494;
        public const string Format = "";
    }
    public static class Ownmode
    {
        public const string DisplayName = "Ownmode";
        public const string Name = "ERR_OWNMODE";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 494;
        public const string Format = "<client> <nick> :cannot answer you while you are <mode>, your message was not sent";
    }
    public static class Badlogtype
    {
        public const string DisplayName = "Badlogtype";
        public const string Name = "ERR_BADLOGTYPE";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 495;
        public const string Format = "";
    }
    public static class Delayrejoin
    {
        public const string DisplayName = "Delayrejoin";
        public const string Name = "ERR_DELAYREJOIN";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 495;
        public const string Format = "<channel> :You cannot rejoin this channel yet after being kicked (+J)";
    }
    public static class Badlogsys
    {
        public const string DisplayName = "Badlogsys";
        public const string Name = "ERR_BADLOGSYS";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 496;
        public const string Format = "";
    }
    public static class Badlogvalue
    {
        public const string DisplayName = "Badlogvalue";
        public const string Name = "ERR_BADLOGVALUE";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 497;
        public const string Format = "";
    }
    public static class Isoperlchan
    {
        public const string DisplayName = "Isoperlchan";
        public const string Name = "ERR_ISOPERLCHAN";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 498;
        public const string Format = "";
    }
    public static class Chanownprivneeded
    {
        public const string DisplayName = "Chanownprivneeded";
        public const string Name = "ERR_CHANOWNPRIVNEEDED";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 499;
        public const string Format = "";
    }
    public static class Toomanyjoins
    {
        public const string DisplayName = "Toomanyjoins";
        public const string Name = "ERR_TOOMANYJOINS";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 500;
        public const string Format = "<client> <string> :Too many join requests. Please wait a while and try again.";
    }
    public static class Norehashparam
    {
        public const string DisplayName = "Norehashparam";
        public const string Name = "ERR_NOREHASHPARAM";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 500;
        public const string Format = "";
    }
    public static class Cannotsetmoder
    {
        public const string DisplayName = "Cannotsetmoder";
        public const string Name = "ERR_CANNOTSETMODER";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 500;
        public const string Format = "<client> :Only a server may modify the +r user/channel mode";
    }
    public static class Umodeunknownflag
    {
        public const string DisplayName = "Umodeunknownflag";
        public const string Name = "ERR_UMODEUNKNOWNFLAG";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 501;
        public const string Format = "<client> :<reason>";
    }
    public static class Unknownsnomask
    {
        public const string DisplayName = "Unknownsnomask";
        public const string Name = "ERR_UNKNOWNSNOMASK";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 501;
        public const string Format = "<client> <snomask> :is unknown mode char to me";
    }
    public static class Usersdontmatch
    {
        public const string DisplayName = "Usersdontmatch";
        public const string Name = "ERR_USERSDONTMATCH";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 502;
        public const string Format = "<client> :<reason>";
    }
    public static class Ghostedclient
    {
        public const string DisplayName = "Ghostedclient";
        public const string Name = "ERR_GHOSTEDCLIENT";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 503;
        public const string Format = "<client> :Message could not be delivered to <target>";
    }
    public static class Vworldwarn
    {
        public const string DisplayName = "Vworldwarn";
        public const string Name = "ERR_VWORLDWARN";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 503;
        public const string Format = "<client> :<warning_text>";
    }
    public static class Usernotonserv
    {
        public const string DisplayName = "Usernotonserv";
        public const string Name = "ERR_USERNOTONSERV";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 504;
        public const string Format = "";
    }
    public static class Silelistfull
    {
        public const string DisplayName = "Silelistfull";
        public const string Name = "ERR_SILELISTFULL";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 511;
        public const string Format = "";
    }
    public static class Toomanywatch
    {
        public const string DisplayName = "Toomanywatch";
        public const string Name = "ERR_TOOMANYWATCH";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 512;
        public const string Format = "";
    }
    public static class Nosuchgline
    {
        public const string DisplayName = "Nosuchgline";
        public const string Name = "ERR_NOSUCHGLINE";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 512;
        public const string Format = "";
    }
    public static class Badping
    {
        public const string DisplayName = "Badping";
        public const string Name = "ERR_BADPING";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 513;
        public const string Format = "";
    }
    public static class Toomanydcc
    {
        public const string DisplayName = "Toomanydcc";
        public const string Name = "ERR_TOOMANYDCC";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 514;
        public const string Format = "";
    }
    public static class Nosuchjupe
    {
        public const string DisplayName = "Nosuchjupe";
        public const string Name = "ERR_NOSUCHJUPE";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 514;
        public const string Format = "";
    }
    public static class Invalid_error
    {
        public const string DisplayName = "Invalid_error";
        public const string Name = "ERR_INVALID_ERROR";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 514;
        public const string Format = "";
    }
    public static class Badexpire
    {
        public const string DisplayName = "Badexpire";
        public const string Name = "ERR_BADEXPIRE";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 515;
        public const string Format = "";
    }
    public static class Dontcheat
    {
        public const string DisplayName = "Dontcheat";
        public const string Name = "ERR_DONTCHEAT";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 516;
        public const string Format = "";
    }
    public static class Disabled
    {
        public const string DisplayName = "Disabled";
        public const string Name = "ERR_DISABLED";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 517;
        public const string Format = "<client> <command> :<info/reason>";
    }
    public static class Noinvite
    {
        public const string DisplayName = "Noinvite";
        public const string Name = "ERR_NOINVITE";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 518;
        public const string Format = "";
    }
    public static class Longmask
    {
        public const string DisplayName = "Longmask";
        public const string Name = "ERR_LONGMASK";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 518;
        public const string Format = "";
    }
    public static class Admonly
    {
        public const string DisplayName = "Admonly";
        public const string Name = "ERR_ADMONLY";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 519;
        public const string Format = "";
    }
    public static class Toomanyusers
    {
        public const string DisplayName = "Toomanyusers";
        public const string Name = "ERR_TOOMANYUSERS";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 519;
        public const string Format = "";
    }
    public static class Operonly
    {
        public const string DisplayName = "Operonly";
        public const string Name = "ERR_OPERONLY";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 520;
        public const string Format = ":Cannot join channel (+O)";
    }
    public static class Masktoowide
    {
        public const string DisplayName = "Masktoowide";
        public const string Name = "ERR_MASKTOOWIDE";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 520;
        public const string Format = "";
    }
    public static class Whotrunc
    {
        public const string DisplayName = "Whotrunc";
        public const string Name = "ERR_WHOTRUNC";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 520;
        public const string Format = "";
    }
    public static class Whosyntax
    {
        public const string DisplayName = "Whosyntax";
        public const string Name = "ERR_WHOSYNTAX";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 522;
        public const string Format = "";
    }
    public static class Wholimexceed
    {
        public const string DisplayName = "Wholimexceed";
        public const string Name = "ERR_WHOLIMEXCEED";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 523;
        public const string Format = "<limit> :<command> search limit exceeded.";
    }
    public static class Quarantined
    {
        public const string DisplayName = "Quarantined";
        public const string Name = "ERR_QUARANTINED";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 524;
        public const string Format = "";
    }
    public static class Operspverify
    {
        public const string DisplayName = "Operspverify";
        public const string Name = "ERR_OPERSPVERIFY";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 524;
        public const string Format = "";
    }
    public static class Helpnotfound
    {
        public const string DisplayName = "Helpnotfound";
        public const string Name = "ERR_HELPNOTFOUND";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 524;
        public const string Format = "<term> :Help not found";
    }
    public static class Invalidkey
    {
        public const string DisplayName = "Invalidkey";
        public const string Name = "ERR_INVALIDKEY";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 525;
        public const string Format = "";
    }
    public static class Remotepfx
    {
        public const string DisplayName = "Remotepfx";
        public const string Name = "ERR_REMOTEPFX";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 525;
        public const string Format = "<nickname> :<reason>";
    }
    public static class Pfxunroutable
    {
        public const string DisplayName = "Pfxunroutable";
        public const string Name = "ERR_PFXUNROUTABLE";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 526;
        public const string Format = "<nickname> :<reason>";
    }
    public static class Cantsendtouser
    {
        public const string DisplayName = "Cantsendtouser";
        public const string Name = "ERR_CANTSENDTOUSER";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 531;
        public const string Format = "<client> <nick> :You are not permitted to send private messages to this user";
    }
    public static class Badhostmask
    {
        public const string DisplayName = "Badhostmask";
        public const string Name = "ERR_BADHOSTMASK";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 550;
        public const string Format = "";
    }
    public static class Hostunavail
    {
        public const string DisplayName = "Hostunavail";
        public const string Name = "ERR_HOSTUNAVAIL";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 551;
        public const string Format = "";
    }
    public static class Usingsline
    {
        public const string DisplayName = "Usingsline";
        public const string Name = "ERR_USINGSLINE";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 552;
        public const string Format = "";
    }
    public static class Notloweroplevel
    {
        public const string DisplayName = "Notloweroplevel";
        public const string Name = "ERR_NOTLOWEROPLEVEL";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 560;
        public const string Format = "";
    }
    public static class Notmanager
    {
        public const string DisplayName = "Notmanager";
        public const string Name = "ERR_NOTMANAGER";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 561;
        public const string Format = "";
    }
    public static class Chansecured
    {
        public const string DisplayName = "Chansecured";
        public const string Name = "ERR_CHANSECURED";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 562;
        public const string Format = "";
    }
    public static class Upassset
    {
        public const string DisplayName = "Upassset";
        public const string Name = "ERR_UPASSSET";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 563;
        public const string Format = "";
    }
    public static class Upassnotset
    {
        public const string DisplayName = "Upassnotset";
        public const string Name = "ERR_UPASSNOTSET";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 564;
        public const string Format = "";
    }
    public static class Nomanager
    {
        public const string DisplayName = "Nomanager";
        public const string Name = "ERR_NOMANAGER";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 566;
        public const string Format = "";
    }
    public static class Upass_same_apass
    {
        public const string DisplayName = "Upass_same_apass";
        public const string Name = "ERR_UPASS_SAME_APASS";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 567;
        public const string Format = "";
    }
    public static class Lasterror
    {
        public const string DisplayName = "Lasterror";
        public const string Name = "ERR_LASTERROR";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 568;
        public const string Format = "";
    }
    public static class Noomotd
    {
        public const string DisplayName = "Noomotd";
        public const string Name = "RPL_NOOMOTD";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 568;
        public const string Format = "";
    }
    public static class Reaway
    {
        public const string DisplayName = "Reaway";
        public const string Name = "RPL_REAWAY";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 597;
        public const string Format = "";
    }
    public static class Goneaway
    {
        public const string DisplayName = "Goneaway";
        public const string Name = "RPL_GONEAWAY";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 598;
        public const string Format = "";
    }
    public static class Notaway
    {
        public const string DisplayName = "Notaway";
        public const string Name = "RPL_NOTAWAY";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 599;
        public const string Format = "";
    }
    public static class Logon
    {
        public const string DisplayName = "Logon";
        public const string Name = "RPL_LOGON";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 600;
        public const string Format = "";
    }
    public static class Logoff
    {
        public const string DisplayName = "Logoff";
        public const string Name = "RPL_LOGOFF";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 601;
        public const string Format = "";
    }
    public static class Watchoff
    {
        public const string DisplayName = "Watchoff";
        public const string Name = "RPL_WATCHOFF";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 602;
        public const string Format = "";
    }
    public static class Watchstat
    {
        public const string DisplayName = "Watchstat";
        public const string Name = "RPL_WATCHSTAT";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 603;
        public const string Format = "";
    }
    public static class Nowon
    {
        public const string DisplayName = "Nowon";
        public const string Name = "RPL_NOWON";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 604;
        public const string Format = "";
    }
    public static class Nowoff
    {
        public const string DisplayName = "Nowoff";
        public const string Name = "RPL_NOWOFF";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 605;
        public const string Format = "";
    }
    public static class Watchlist
    {
        public const string DisplayName = "Watchlist";
        public const string Name = "RPL_WATCHLIST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 606;
        public const string Format = "";
    }
    public static class Endofwatchlist
    {
        public const string DisplayName = "Endofwatchlist";
        public const string Name = "RPL_ENDOFWATCHLIST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 607;
        public const string Format = "";
    }
    public static class Watchclear
    {
        public const string DisplayName = "Watchclear";
        public const string Name = "RPL_WATCHCLEAR";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 608;
        public const string Format = "";
    }
    public static class Nowisaway
    {
        public const string DisplayName = "Nowisaway";
        public const string Name = "RPL_NOWISAWAY";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 609;
        public const string Format = "";
    }
    public static class Isoper
    {
        public const string DisplayName = "Isoper";
        public const string Name = "RPL_ISOPER";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 610;
        public const string Format = "";
    }
    public static class Islocop
    {
        public const string DisplayName = "Islocop";
        public const string Name = "RPL_ISLOCOP";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 611;
        public const string Format = "";
    }
    public static class Isnotoper
    {
        public const string DisplayName = "Isnotoper";
        public const string Name = "RPL_ISNOTOPER";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 612;
        public const string Format = "";
    }
    public static class Endofisoper
    {
        public const string DisplayName = "Endofisoper";
        public const string Name = "RPL_ENDOFISOPER";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 613;
        public const string Format = "";
    }
    public static class Whoissslfp
    {
        public const string DisplayName = "Whoissslfp";
        public const string Name = "RPL_WHOISSSLFP";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 617;
        public const string Format = "<client> <nick> :has client certificate fingerprint <fingerprint>";
    }
    public static class Dccstatus
    {
        public const string DisplayName = "Dccstatus";
        public const string Name = "RPL_DCCSTATUS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 617;
        public const string Format = "";
    }
    public static class Dcclist
    {
        public const string DisplayName = "Dcclist";
        public const string Name = "RPL_DCCLIST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 618;
        public const string Format = "";
    }
    public static class Endofdcclist
    {
        public const string DisplayName = "Endofdcclist";
        public const string Name = "RPL_ENDOFDCCLIST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 619;
        public const string Format = "";
    }
    public static class Whowashost
    {
        public const string DisplayName = "Whowashost";
        public const string Name = "RPL_WHOWASHOST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 619;
        public const string Format = "";
    }
    public static class Dccinfo
    {
        public const string DisplayName = "Dccinfo";
        public const string Name = "RPL_DCCINFO";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 620;
        public const string Format = "";
    }
    public static class Omotdstart
    {
        public const string DisplayName = "Omotdstart";
        public const string Name = "RPL_OMOTDSTART";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 624;
        public const string Format = "";
    }
    public static class Omotd
    {
        public const string DisplayName = "Omotd";
        public const string Name = "RPL_OMOTD";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 625;
        public const string Format = "";
    }
    public static class Endofomotd
    {
        public const string DisplayName = "Endofomotd";
        public const string Name = "RPL_ENDOFOMOTD";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 626;
        public const string Format = "";
    }
    public static class Settings
    {
        public const string DisplayName = "Settings";
        public const string Name = "RPL_SETTINGS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 630;
        public const string Format = "";
    }
    public static class Endofsettings
    {
        public const string DisplayName = "Endofsettings";
        public const string Name = "RPL_ENDOFSETTINGS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 631;
        public const string Format = "";
    }
    public static class Dumping
    {
        public const string DisplayName = "Dumping";
        public const string Name = "RPL_DUMPING";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 640;
        public const string Format = "";
    }
    public static class Dumprpl
    {
        public const string DisplayName = "Dumprpl";
        public const string Name = "RPL_DUMPRPL";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 641;
        public const string Format = "";
    }
    public static class Eodump
    {
        public const string DisplayName = "Eodump";
        public const string Name = "RPL_EODUMP";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 642;
        public const string Format = "";
    }
    public static class Syntax
    {
        public const string DisplayName = "Syntax";
        public const string Name = "RPL_SYNTAX";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 650;
        public const string Format = "<client> <command> :<syntax>";
    }
    public static class Channelsmsg
    {
        public const string DisplayName = "Channelsmsg";
        public const string Name = "RPL_CHANNELSMSG";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 651;
        public const string Format = "<client> <nick> :is on private/ secret channels:";
    }
    public static class Uninvited
    {
        public const string DisplayName = "Uninvited";
        public const string Name = "RPL_UNINVITED";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 653;
        public const string Format = "< client > :You were uninvited from<chan> by<nick>";
    }
    public static class Spamcmdfwd
    {
        public const string DisplayName = "Spamcmdfwd";
        public const string Name = "RPL_SPAMCMDFWD";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 659;
        public const string Format = "<client> <command> :Command processed, but a copy has been sent to ircops for evaluation (anti-spam) purposes. [<reason>]";
    }
    public static class Starttls
    {
        public const string DisplayName = "Starttls";
        public const string Name = "RPL_STARTTLS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 670;
        public const string Format = "<client> :STARTTLS successful, proceed with TLS handshake";
    }
    public static class Whoissecure
    {
        public const string DisplayName = "Whoissecure";
        public const string Name = "RPL_WHOISSECURE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 671;
        public const string Format = "<client> <nick> :is using a secure connection";
    }
    public static class Unknownmodes
    {
        public const string DisplayName = "Unknownmodes";
        public const string Name = "RPL_UNKNOWNMODES";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 672;
        public const string Format = "< modes > :< info >";
    }
    public static class Whoisrealip
    {
        public const string DisplayName = "Whoisrealip";
        public const string Name = "RPL_WHOISREALIP";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 672;
        public const string Format = "< client > < nick > :is actually from < ip >";
    }
    public static class Cannotsetmodes
    {
        public const string DisplayName = "Cannotsetmodes";
        public const string Name = "RPL_CANNOTSETMODES";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 673;
        public const string Format = "< modes > :< info >";
    }
    public static class Whoisyourid
    {
        public const string DisplayName = "Whoisyourid";
        public const string Name = "RPL_WHOISYOURID";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 674;
        public const string Format = "< client > :EUID is < euid >";
    }
    public static class Redirect
    {
        public const string DisplayName = "Redirect";
        public const string Name = "ERR_REDIRECT";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 690;
        public const string Format = "< client > :Target channel #chan must exist to be set as a redirect";
    }
    public static class Invalidmodeparam
    {
        public const string DisplayName = "Invalidmodeparam";
        public const string Name = "ERR_INVALIDMODEPARAM";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 696;
        public const string Format = "< client > < target chan / user > < mode char> < parameter > :< description >";
    }
    public static class Listmodealreadyset
    {
        public const string DisplayName = "Listmodealreadyset";
        public const string Name = "ERR_LISTMODEALREADYSET";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 697;
        public const string Format = "<client> <target chan> <parameter> <mode char> :<description>";
    }
    public static class Listmodenotset
    {
        public const string DisplayName = "Listmodenotset";
        public const string Name = "ERR_LISTMODENOTSET";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 698;
        public const string Format = "<client> <target chan> <parameter> <mode char> :<description>";
    }
    public static class Commands
    {
        public const string DisplayName = "Commands";
        public const string Name = "RPL_COMMANDS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 700;
        public const string Format = "<client> :<command> <module name> <minimum parameters> <penalty>";
    }
    public static class Commandsend
    {
        public const string DisplayName = "Commandsend";
        public const string Name = "RPL_COMMANDSEND";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 701;
        public const string Format = "<client> :End of COMMANDS list";
    }
    public static class Endofmodlist
    {
        public const string DisplayName = "Endofmodlist";
        public const string Name = "RPL_ENDOFMODLIST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 703;
        public const string Format = "<client> :<text>";
    }
    public static class Helpstart
    {
        public const string DisplayName = "Helpstart";
        public const string Name = "RPL_HELPSTART";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 704;
        public const string Format = "<client> <command> :<text>";
    }
    public static class Helptxt
    {
        public const string DisplayName = "Helptxt";
        public const string Name = "RPL_HELPTXT";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 705;
        public const string Format = "<client> <command> :<text>";
    }
    public static class Endofhelp
    {
        public const string DisplayName = "Endofhelp";
        public const string Name = "RPL_ENDOFHELP";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 706;
        public const string Format = "<client> <command> :<text>";
    }
    public static class Targchange
    {
        public const string DisplayName = "Targchange";
        public const string Name = "ERR_TARGCHANGE";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 707;
        public const string Format = "<client> <target> :Targets changing too fast, message dropped";
    }
    public static class Etracefull
    {
        public const string DisplayName = "Etracefull";
        public const string Name = "RPL_ETRACEFULL";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 708;
        public const string Format = "<client> <Oper|User> <class> < nick > < username > < host > < ip > :< capabilities >";
    }
    public static class Etrace
    {
        public const string DisplayName = "Etrace";
        public const string Name = "RPL_ETRACE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 709;
        public const string Format = "< client > < Oper | User > <?> < nick > < username > < host > :< ip >";
    }
    public static class Knock
    {
        public const string DisplayName = "Knock";
        public const string Name = "RPL_KNOCK";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 710;
        public const string Format = "< client > < channel > < nick > !< user >@< host > :< text >";
    }
    public static class Knockdlvr
    {
        public const string DisplayName = "Knockdlvr";
        public const string Name = "RPL_KNOCKDLVR";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 711;
        public const string Format = "< client > < channel > :< text >";
    }
    public static class Toomanyknock
    {
        public const string DisplayName = "Toomanyknock";
        public const string Name = "ERR_TOOMANYKNOCK";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 712;
        public const string Format = "< client > < channel > :< text >";
    }
    public static class Chanopen
    {
        public const string DisplayName = "Chanopen";
        public const string Name = "ERR_CHANOPEN";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 713;
        public const string Format = "< client > < channel > :< text >";
    }
    public static class Knockonchan
    {
        public const string DisplayName = "Knockonchan";
        public const string Name = "ERR_KNOCKONCHAN";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 714;
        public const string Format = "< client > < channel > :< text >";
    }
    public static class Knockdisabled
    {
        public const string DisplayName = "Knockdisabled";
        public const string Name = "ERR_KNOCKDISABLED";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 715;
        public const string Format = "< client > :< text >";
    }
    public static class Toomanyinvite
    {
        public const string DisplayName = "Toomanyinvite";
        public const string Name = "ERR_TOOMANYINVITE";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 715;
        public const string Format = "< client > < channel > :Too many INVITEs(< channel / user >).";
    }
    public static class Invitethrottle
    {
        public const string DisplayName = "Invitethrottle";
        public const string Name = "RPL_INVITETHROTTLE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 715;
        public const string Format = "<client> <nick> <channel> :You are inviting too fast";
    }
    public static class Targumodeg
    {
        public const string DisplayName = "Targumodeg";
        public const string Name = "RPL_TARGUMODEG";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 716;
        public const string Format = "< nick > :< info >";
    }
    public static class Targnotify
    {
        public const string DisplayName = "Targnotify";
        public const string Name = "RPL_TARGNOTIFY";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 717;
        public const string Format = "< nick > :< info >";
    }
    public static class Umodegmsg
    {
        public const string DisplayName = "Umodegmsg";
        public const string Name = "RPL_UMODEGMSG";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 718;
        public const string Format = "< client > < nick > < user >@< host > :< info >";
    }
    public static class Noprivs
    {
        public const string DisplayName = "Noprivs";
        public const string Name = "ERR_NOPRIVS";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 723;
        public const string Format = "<client> <command> :<text>";
    }
    public static class Testmask
    {
        public const string DisplayName = "Testmask";
        public const string Name = "RPL_TESTMASK";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 724;
        public const string Format = "<client> <nick>!<user>@<host> <?> <?> :<text>";
    }
    public static class Testline
    {
        public const string DisplayName = "Testline";
        public const string Name = "RPL_TESTLINE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 725;
        public const string Format = "<client> <?> <?> <?> :<?>";
    }
    public static class Notestline
    {
        public const string DisplayName = "Notestline";
        public const string Name = "RPL_NOTESTLINE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 726;
        public const string Format = "<client> <?> :<text>";
    }
    public static class Testmaskgecos
    {
        public const string DisplayName = "Testmaskgecos";
        public const string Name = "RPL_TESTMASKGECOS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 727;
        public const string Format = "<client> <lcount> <gcount> <nick>!<user>@<host> <gecos> :Local/remote clients match";
    }
    public static class Quietlist
    {
        public const string DisplayName = "Quietlist";
        public const string Name = "RPL_QUIETLIST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 728;
        public const string Format = "<client> <channel> q<banid>[< time_left > :< reason >]";
    }
    public static class Endofquietlist
    {
        public const string DisplayName = "Endofquietlist";
        public const string Name = "RPL_ENDOFQUIETLIST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 729;
        public const string Format = "<client> <channel> q :<info>";
    }
    public static class Mononline
    {
        public const string DisplayName = "Mononline";
        public const string Name = "RPL_MONONLINE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 730;
        public const string Format = "<client> :target[!user@host][,target[!user@host]]*";
    }
    public static class Monoffline
    {
        public const string DisplayName = "Monoffline";
        public const string Name = "RPL_MONOFFLINE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 731;
        public const string Format = "<client> :target[,target2]*";
    }
    public static class Monlist
    {
        public const string DisplayName = "Monlist";
        public const string Name = "RPL_MONLIST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 732;
        public const string Format = "<client> :target[,target2]*";
    }
    public static class Endofmonlist
    {
        public const string DisplayName = "Endofmonlist";
        public const string Name = "RPL_ENDOFMONLIST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 733;
        public const string Format = "<client> :End of MONITOR list";
    }
    public static class Monlistfull
    {
        public const string DisplayName = "Monlistfull";
        public const string Name = "ERR_MONLISTFULL";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 734;
        public const string Format = "<client> <limit> <targets> :Monitor list is full.";
    }
    public static class Rsachallenge2
    {
        public const string DisplayName = "Rsachallenge2";
        public const string Name = "RPL_RSACHALLENGE2";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 740;
        public const string Format = "<client> :<chal_line>";
    }
    public static class Endofrsachallenge2
    {
        public const string DisplayName = "Endofrsachallenge2";
        public const string Name = "RPL_ENDOFRSACHALLENGE2";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 741;
        public const string Format = "<client> :End of CHALLENGE";
    }
    public static class Mlockrestricted
    {
        public const string DisplayName = "Mlockrestricted";
        public const string Name = "ERR_MLOCKRESTRICTED";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 742;
        public const string Format = "<client> <channel> <modechar> <mlock> :MODE cannot be set due to channel having an active MLOCK restriction policy";
    }
    public static class Invalidban
    {
        public const string DisplayName = "Invalidban";
        public const string Name = "ERR_INVALIDBAN";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 743;
        public const string Format = "<channel> <modechar> <mask> :Invalid ban mask";
    }
    public static class Topiclock
    {
        public const string DisplayName = "Topiclock";
        public const string Name = "ERR_TOPICLOCK";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 744;
        public const string Format = "";
    }
    public static class Scanmatched
    {
        public const string DisplayName = "Scanmatched";
        public const string Name = "RPL_SCANMATCHED";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 750;
        public const string Format = "<count> :matches";
    }
    public static class Scanumodes
    {
        public const string DisplayName = "Scanumodes";
        public const string Name = "RPL_SCANUMODES";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 751;
        public const string Format = "<nick> <username> <host> <sockhost> <servname> <umodes> :<info>";
    }
    public static class Etraceend
    {
        public const string DisplayName = "Etraceend";
        public const string Name = "RPL_ETRACEEND";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 759;
        public const string Format = "";
    }
    public static class Whoiskeyvalue
    {
        public const string DisplayName = "Whoiskeyvalue";
        public const string Name = "RPL_WHOISKEYVALUE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 760;
        public const string Format = "<Target> <Key> <Visibility> :<Value>";
    }
    public static class Keyvalue
    {
        public const string DisplayName = "Keyvalue";
        public const string Name = "RPL_KEYVALUE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 761;
        public const string Format = "<Target> <Key> <Visibility>[ :<Value>]";
    }
    public static class Metadataend
    {
        public const string DisplayName = "Metadataend";
        public const string Name = "RPL_METADATAEND";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 762;
        public const string Format = ":end of metadata";
    }
    public static class Metadatalimit
    {
        public const string DisplayName = "Metadatalimit";
        public const string Name = "ERR_METADATALIMIT";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 764;
        public const string Format = "<Target> :metadata limit reached";
    }
    public static class Targetinvalid
    {
        public const string DisplayName = "Targetinvalid";
        public const string Name = "ERR_TARGETINVALID";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 765;
        public const string Format = "<Target> :invalid metadata target";
    }
    public static class Nomatchingkey
    {
        public const string DisplayName = "Nomatchingkey";
        public const string Name = "ERR_NOMATCHINGKEY";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 766;
        public const string Format = "<Key> :no matching key";
    }
    public static class Keyinvalid
    {
        public const string DisplayName = "Keyinvalid";
        public const string Name = "ERR_KEYINVALID";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 767;
        public const string Format = "<Key> :invalid metadata key";
    }
    public static class Keynotset
    {
        public const string DisplayName = "Keynotset";
        public const string Name = "ERR_KEYNOTSET";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 768;
        public const string Format = "<Target> <Key> :key not set";
    }
    public static class Keynopermission
    {
        public const string DisplayName = "Keynopermission";
        public const string Name = "ERR_KEYNOPERMISSION";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 769;
        public const string Format = "<Target> <Key> :permission denied";
    }
    public static class Xinfo
    {
        public const string DisplayName = "Xinfo";
        public const string Name = "RPL_XINFO";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 771;
        public const string Format = "";
    }
    public static class Xinfostart
    {
        public const string DisplayName = "Xinfostart";
        public const string Name = "RPL_XINFOSTART";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 773;
        public const string Format = "";
    }
    public static class Xinfoend
    {
        public const string DisplayName = "Xinfoend";
        public const string Name = "RPL_XINFOEND";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 774;
        public const string Format = "";
    }
    public static class Statscountry
    {
        public const string DisplayName = "Statscountry";
        public const string Name = "RPL_STATSCOUNTRY";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 801;
        public const string Format = "<count> <code> :<country>";
    }
    public static class Check
    {
        public const string DisplayName = "Check";
        public const string Name = "RPL_CHECK";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 802;
        public const string Format = "";
    }
    public static class Otherumodeis
    {
        public const string DisplayName = "Otherumodeis";
        public const string Name = "RPL_OTHERUMODEIS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 803;
        public const string Format = "<client> <nick> <user modes> <user mode parameters>";
    }
    public static class Othersnomaskis
    {
        public const string DisplayName = "Othersnomaskis";
        public const string Name = "RPL_OTHERSNOMASKIS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 804;
        public const string Format = "<client> <nick> <server notice mask> :Server notice mask";
    }
    public static class Loggedin
    {
        public const string DisplayName = "Loggedin";
        public const string Name = "RPL_LOGGEDIN";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 900;
        public const string Format = "<client> <nick>!<ident>@<host> <account> :You are now logged in as <user>";
    }
    public static class Loggedout
    {
        public const string DisplayName = "Loggedout";
        public const string Name = "RPL_LOGGEDOUT";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 901;
        public const string Format = "<client> <nick>!<ident>@<host> :You are now logged out";
    }
    public static class Nicklocked
    {
        public const string DisplayName = "Nicklocked";
        public const string Name = "ERR_NICKLOCKED";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 902;
        public const string Format = "<client> :You must use a nick assigned to you.";
    }
    public static class Saslsuccess
    {
        public const string DisplayName = "Saslsuccess";
        public const string Name = "RPL_SASLSUCCESS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 903;
        public const string Format = "<client> :SASL authentication successful";
    }
    public static class Saslfail
    {
        public const string DisplayName = "Saslfail";
        public const string Name = "ERR_SASLFAIL";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 904;
        public const string Format = "< client > :SASL authentication failed";
    }
    public static class Sasltoolong
    {
        public const string DisplayName = "Sasltoolong";
        public const string Name = "ERR_SASLTOOLONG";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 905;
        public const string Format = "< client > :SASL message too long";
    }
    public static class Saslaborted
    {
        public const string DisplayName = "Saslaborted";
        public const string Name = "ERR_SASLABORTED";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 906;
        public const string Format = "< client > :SASL authentication aborted";
    }
    public static class Saslalready
    {
        public const string DisplayName = "Saslalready";
        public const string Name = "ERR_SASLALREADY";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 907;
        public const string Format = "< client > :You have already authenticated using SASL";
    }
    public static class Saslmechs
    {
        public const string DisplayName = "Saslmechs";
        public const string Name = "RPL_SASLMECHS";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 908;
        public const string Format = "IRCv3";
    }
    public static class Accesslist
    {
        public const string DisplayName = "Accesslist";
        public const string Name = "RPL_ACCESSLIST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 910;
        public const string Format = "< client > < channel > < status >:< mask > < who > < set - ts >";
    }
    public static class Endofaccesslist
    {
        public const string DisplayName = "Endofaccesslist";
        public const string Name = "RPL_ENDOFACCESSLIST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 911;
        public const string Format = "< client > < channel > :End of channel access list";
    }
    public static class Badchannel
    {
        public const string DisplayName = "Badchannel";
        public const string Name = "ERR_BADCHANNEL";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 926;
        public const string Format = "< client > < channel > :Channel<channel> is forbidden: < reason >";
    }
    public static class Wordfiltered
    {
        public const string DisplayName = "Wordfiltered";
        public const string Name = "ERR_WORDFILTERED";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 936;
        public const string Format = "<client> <channel> <message> :Your message contained a censored word";
    }
    public static class Alreadychanfiltered
    {
        public const string DisplayName = "Alreadychanfiltered";
        public const string Name = "ERR_ALREADYCHANFILTERED";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 937;
        public const string Format = "< client > < chan > :The word<word> is already on the spamfilter list";
    }
    public static class Nosuchchanfilter
    {
        public const string DisplayName = "Nosuchchanfilter";
        public const string Name = "ERR_NOSUCHCHANFILTER";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 938;
        public const string Format = "< client > < chan > :No such spamfilter word is set";
    }
    public static class Chanfilterfull
    {
        public const string DisplayName = "Chanfilterfull";
        public const string Name = "ERR_CHANFILTERFULL";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 939;
        public const string Format = "< client > < chan > :Channel spamfilter list is full";
    }
    public static class Endofspamfilter
    {
        public const string DisplayName = "Endofspamfilter";
        public const string Name = "RPL_ENDOFSPAMFILTER";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 940;
        public const string Format = "< client > < channel > :End of channel spamfilter list";
    }
    public static class Spamfilter
    {
        public const string DisplayName = "Spamfilter";
        public const string Name = "RPL_SPAMFILTER";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 941;
        public const string Format = "< client > < channel > < filter > < who > < set - ts >";
    }
    public static class Invalidwatchnick
    {
        public const string DisplayName = "Invalidwatchnick";
        public const string Name = "ERR_INVALIDWATCHNICK";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 942;
        public const string Format = "< client > < nick > :Invalid nickname";
    }
    public static class Idletimeset
    {
        public const string DisplayName = "Idletimeset";
        public const string Name = "RPL_IDLETIMESET";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 944;
        public const string Format = "< client > :Idle time set.";
    }
    public static class Nicklockoff
    {
        public const string DisplayName = "Nicklockoff";
        public const string Name = "RPL_NICKLOCKOFF";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 945;
        public const string Format = "< client > < nick > :Nickname now unlocked.";
    }
    public static class Nicknotlocked
    {
        public const string DisplayName = "Nicknotlocked";
        public const string Name = "ERR_NICKNOTLOCKED";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 946;
        public const string Format = "< client > < nick > :This user's nickname is not locked.";
    }
    public static class Nicklockon
    {
        public const string DisplayName = "Nicklockon";
        public const string Name = "RPL_NICKLOCKON";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 947;
        public const string Format = "< client > < nick > :Nickname now locked.";
    }
    public static class Invalididletime
    {
        public const string DisplayName = "Invalididletime";
        public const string Name = "ERR_INVALIDIDLETIME";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 948;
        public const string Format = "< client > :Invalid idle time.";
    }
    public static class Unsilenced
    {
        public const string DisplayName = "Unsilenced";
        public const string Name = "RPL_UNSILENCED";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 950;
        public const string Format = "< client > < nick > :Removed<mask> < pattern > from silence list";
    }
    public static class Silenced
    {
        public const string DisplayName = "Silenced";
        public const string Name = "RPL_SILENCED";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 951;
        public const string Format = "< client > < nick > :Added<mask> < pattern > to silence list";
    }
    public static class Silence
    {
        public const string DisplayName = "Silence";
        public const string Name = "ERR_SILENCE";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 952;
        public const string Format = "< client > < mask > [< flags >] :< reason >";
    }
    public static class Endofexemptionlist
    {
        public const string DisplayName = "Endofexemptionlist";
        public const string Name = "RPL_ENDOFEXEMPTIONLIST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 953;
        public const string Format = "< client > < channel > :End of channel exemptchanops list";
    }
    public static class Exemptionlist
    {
        public const string DisplayName = "Exemptionlist";
        public const string Name = "RPL_EXEMPTIONLIST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 954;
        public const string Format = "< client > < channel > < exception > < who > :< set - ts >";
    }
    public static class Endofproplist
    {
        public const string DisplayName = "Endofproplist";
        public const string Name = "RPL_ENDOFPROPLIST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 960;
        public const string Format = "< client > < channel > :End of mode list";
    }
    public static class Proplist
    {
        public const string DisplayName = "Proplist";
        public const string Name = "RPL_PROPLIST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 961;
        public const string Format = "< client > < channel > [+< mode >]...";
    }
    public static class Cannotdocommand
    {
        public const string DisplayName = "Cannotdocommand";
        public const string Name = "ERR_CANNOTDOCOMMAND";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 972;
        public const string Format = "< client > < command > :< info >";
    }
    public static class Cantunloadmodule
    {
        public const string DisplayName = "Cantunloadmodule";
        public const string Name = "ERR_CANTUNLOADMODULE";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 972;
        public const string Format = "< client > < modulename > :Failed to unload module: < error >";
    }
    public static class Unloadedmodule
    {
        public const string DisplayName = "Unloadedmodule";
        public const string Name = "RPL_UNLOADEDMODULE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 973;
        public const string Format = "< client > < modulename > :Module successfully unloaded.";
    }
    public static class Cannotchangechanmode
    {
        public const string DisplayName = "Cannotchangechanmode";
        public const string Name = "ERR_CANNOTCHANGECHANMODE";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 974;
        public const string Format = "< client > < mode > :< info >";
    }
    public static class Cantloadmodule
    {
        public const string DisplayName = "Cantloadmodule";
        public const string Name = "ERR_CANTLOADMODULE";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 974;
        public const string Format = "< client > < modulename > :Failed to load module: < error >";
    }
    public static class Loadedmodule
    {
        public const string DisplayName = "Loadedmodule";
        public const string Name = "RPL_LOADEDMODULE";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 975;
        public const string Format = "< client > < modulename > :Module successfully loaded.";
    }
    public static class Servlockon
    {
        public const string DisplayName = "Servlockon";
        public const string Name = "RPL_SERVLOCKON";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 988;
        public const string Format = "< client > < server > :Closed for new connections";
    }
    public static class Servlockoff
    {
        public const string DisplayName = "Servlockoff";
        public const string Name = "RPL_SERVLOCKOFF";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 989;
        public const string Format = "< client > < server > :Open for new connections";
    }
    public static class Dccallowstart
    {
        public const string DisplayName = "Dccallowstart";
        public const string Name = "RPL_DCCALLOWSTART";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 990;
        public const string Format = "< client > :Users on your DCCALLOW list:";
    }
    public static class Dccallowlist
    {
        public const string DisplayName = "Dccallowlist";
        public const string Name = "RPL_DCCALLOWLIST";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 991;
        public const string Format = "< client > < nick > :< nick > (< hostmask >)";
    }
    public static class Dccallowend
    {
        public const string DisplayName = "Dccallowend";
        public const string Name = "RPL_DCCALLOWEND";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 992;
        public const string Format = "< client > :End of DCCALLOW list";
    }
    public static class Dccallowtimed
    {
        public const string DisplayName = "Dccallowtimed";
        public const string Name = "RPL_DCCALLOWTIMED";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 993;
        public const string Format = "< client > < nick > :Added < nick > to DCCALLOW list for < count > seconds";
    }
    public static class Dccallowpermanent
    {
        public const string DisplayName = "Dccallowpermanent";
        public const string Name = "RPL_DCCALLOWPERMANENT";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 994;
        public const string Format = "< client > < nick > :Added < nick > to DCCALLOW list for this session";
    }
    public static class Dccallowremoved
    {
        public const string DisplayName = "Dccallowremoved";
        public const string Name = "RPL_DCCALLOWREMOVED";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 995;
        public const string Format = "< client > < nick > :Removed < nick > from your DCCALLOW list";
    }
    public static class Dccallowinvalid
    {
        public const string DisplayName = "Dccallowinvalid";
        public const string Name = "ERR_DCCALLOWINVALID";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 996;
        public const string Format = "< client > < nick > :< reason >";
    }
    public static class Dccallowexpired
    {
        public const string DisplayName = "Dccallowexpired";
        public const string Name = "RPL_DCCALLOWEXPIRED";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 997;
        public const string Format = "< client > < nick > :DCCALLOW entry for < nick > has expired";
    }
    public static class Unknowndccallowcmd
    {
        public const string DisplayName = "Unknowndccallowcmd";
        public const string Name = "ERR_UNKNOWNDCCALLOWCMD";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 998;
        public const string Format = "< client > :DCCALLOW command not understood";
    }
    public static class Dccallowhelp
    {
        public const string DisplayName = "Dccallowhelp";
        public const string Name = "RPL_DCCALLOWHELP";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 998;
        public const string Format = "< client > :< help >";
    }
    public static class Endofdccallowhelp
    {
        public const string DisplayName = "Endofdccallowhelp";
        public const string Name = "RPL_ENDOFDCCALLOWHELP";
        public const ReplyVariant Variant = ReplyVariant.RPL;
        public const int Number = 999;
        public const string Format = "< client > :End of DCCALLOW HELP";
    }
    public static class Numeric_err
    {
        public const string DisplayName = "Numeric_err";
        public const string Name = "ERR_NUMERIC_ERR";
        public const ReplyVariant Variant = ReplyVariant.ERR;
        public const int Number = 999;
        public const string Format = "";
    }

}