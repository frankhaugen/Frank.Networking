using Frank.IRC.Networking.Sockets;

namespace Frank.IRC.Networking;

public class GenericHandler : ISocketMessageHandler
{
    public int Port { get; }

    public GenericHandler(int port)
    {
        Port = port;
    }

    public async Task HandleAsync(SocketMessage message, CancellationToken cancellationToken)
    {
        if (message.Port != Port)
            return;

        await Task.CompletedTask;
    }
}