using System.Text;

using Frank.IRC.Models;

namespace Frank.Networking.Irc.DataHandlers;

public class IrcSocketDataHandler : ISocketDataReceivedHandler
{
    public void OnDataReceived(object sender, SocketDataReceivedEventArgs e)
    {
        var raw = Encoding.UTF8.GetString(e.Data);
        if (IrcMessageRaw.TryParse(raw, null, out var message))
        {
            var ircMessage = new IrcMessage(message);
            
        }
    }
}
