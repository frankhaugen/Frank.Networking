using Frank.Networking.Legacy.Irc.Constants.Replies.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Replies;

public class EndOfNamesReply : Reply
{
    public EndOfNamesReply() : base(ReplyConstants.Endofnames.Name, ReplyConstants.Endofnames.Number, ReplyConstants.Endofnames.Format)
    {
    }
}