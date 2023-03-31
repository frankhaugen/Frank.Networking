using Frank.IRC.Commands.Base;

namespace Frank.IRC.Commands;

public class TopicCommand : Command
{
    public TopicCommand() : base(CommandConstants.Topic.Command, CommandConstants.Topic.Helptext, CommandConstants.Topic.Syntax)
    {
    }
}