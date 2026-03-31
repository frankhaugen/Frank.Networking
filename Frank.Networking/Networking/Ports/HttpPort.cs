using Frank.IRC.Networking.Ports.Base;

namespace Frank.IRC.Networking.Ports;

public class HttpPort : Port
{
    public HttpPort() : base(PortType.Http) { }
}