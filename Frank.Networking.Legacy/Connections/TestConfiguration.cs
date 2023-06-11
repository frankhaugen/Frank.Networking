namespace Frank.Networking.Legacy.Connections;

public class TestConfiguration : SocketConfiguration<TestPort>
{
    public override AddressFamily AddressFamily { get; set; }
    public override SocketType SocketType { get; set; }
    public override ProtocolType ProtocolType { get; set; }
    public override IPAddress Address { get; set; } = IPAddress.Loopback;
    public override TestPort Port { get; set; }
}