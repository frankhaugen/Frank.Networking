namespace Frank.Networking.Legacy;

public class SocketListenerOptions : SocketConnectionOptions
{
    public int Backlog { get; set; } = 100;
}