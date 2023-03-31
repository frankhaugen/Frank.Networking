using System.Text;

using Frank.IRC.Models;
using Frank.Networking.Irc.Helpers;

namespace Frank.Networking.Irc.Server;

public class IrcServer : ISocketConnectionHandler
{
    public void OnDataReceived(object sender, SocketConnectionDataReceivedEventArgs e)
    {
        if (EncodingHelper.TryGetString(e.Data, out var rawString) && IrcMessageRaw.TryParse(rawString, out var message))
        {
            
        }
    }
}
