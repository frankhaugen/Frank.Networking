using Frank.IRC.Replies.Base;

namespace Frank.IRC.Replies;

public class VersionReply : Reply
{
    public VersionReply() : base(ReplyConstants.Version.Name, ReplyConstants.Version.Number, ReplyConstants.Version.Format)
    {
    }
}