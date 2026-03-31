using Frank.IRC.Networking.Ports.Base;

namespace Frank.IRC.Networking.Ports;

public class IrcPort : Port
{
    public IrcPort() : base(PortType.Irc) { }
}