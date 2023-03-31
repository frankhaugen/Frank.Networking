namespace Frank.Networking;

public class SocketListenerOptions : SocketConnectionOptions
{
    public int Backlog { get; set; } = 100;
}