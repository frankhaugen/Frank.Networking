namespace Frank.Networking.Legacy.Connections;

public abstract class SocketConfiguration<T> where T : Port
{
    public abstract AddressFamily AddressFamily { get; set; }
    public abstract SocketType SocketType { get; set; }
    public abstract ProtocolType ProtocolType { get; set; }
    public abstract IPAddress Address { get; set; }
    public abstract T Port { get; set; }
}