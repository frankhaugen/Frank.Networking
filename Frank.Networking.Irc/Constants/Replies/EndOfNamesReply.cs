using Frank.IRC.Replies.Base;

namespace Frank.IRC.Replies;

public class EndOfNamesReply : Reply
{
    public EndOfNamesReply() : base(ReplyConstants.Endofnames.Name, ReplyConstants.Endofnames.Number, ReplyConstants.Endofnames.Format)
    {
    }
}