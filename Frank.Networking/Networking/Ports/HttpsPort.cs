using Frank.IRC.Networking.Ports.Base;

namespace Frank.IRC.Networking.Ports;

public class HttpsPort : Port
{
    public HttpsPort() : base(PortType.Https) { }
}