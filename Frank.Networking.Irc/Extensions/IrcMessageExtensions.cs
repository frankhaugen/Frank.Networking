using Frank.IRC.Commands.Base;
using Frank.IRC.Models;

namespace Frank.Networking.Irc.Helpers;

public static class IrcMessageExtensions
{
    public static IrcCommandName GetCommandName(this IrcMessageRaw message)
    {
        if (message == null)
            throw new ArgumentNullException(nameof(message));

        return CommandHelper.GetCommandName(message.Command);
    }
}