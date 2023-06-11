using Frank.Networking.Legacy.Irc.Constants.Replies.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Replies;

public class VersionReply : Reply
{
    public VersionReply() : base(ReplyConstants.Version.Name, ReplyConstants.Version.Number, ReplyConstants.Version.Format)
    {
    }
}