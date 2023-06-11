using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Commands;

public class TopicCommand : Command
{
    public TopicCommand() : base(CommandConstants.Topic.Command, CommandConstants.Topic.Helptext, CommandConstants.Topic.Syntax)
    {
    }
}