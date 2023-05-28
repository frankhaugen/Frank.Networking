using Frank.IRC.Models;
using Frank.Networking.Irc.Helpers;

namespace Frank.Networking.Irc.Server;

public class IrcSocketHandler : ISocketConnectionHandler
{
    private readonly IrcServer _ircServer;

    public IrcSocketHandler(IrcServer ircServer)
    {
        _ircServer = ircServer;
    }

    public void OnDataReceived(object sender, SocketConnectionDataReceivedEventArgs e)
    {
        if (EncodingHelper.TryGetString(e.Data, out var rawString) && IrcMessageRaw.TryParse(rawString, out var messageRaw))
        {
            var message = new IrcMessage(messageRaw);
            var command = message.GetCommand();
            
            _ircServer.ReceiveCommandAsync(command).GetAwaiter().GetResult();
        }
    }
}
