namespace Frank.IRC.Networking.Sockets;

public class SocketMessage
{
    public string Message { get; set; }
    public int Port { get; set; }
    public DateTime Timestamp { get; } = DateTime.UtcNow;

    public override string ToString() => $"({Timestamp}) [{Port}]: '{Message}'";
}