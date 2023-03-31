using Frank.IRC.Replies.Base;

namespace Frank.IRC.Replies;

public class EndOfBanListReply : Reply
{
    public EndOfBanListReply() : base(ReplyConstants.Endofbanlist.Name, ReplyConstants.Endofbanlist.Number, ReplyConstants.Endofbanlist.Format)
    {
    }
}