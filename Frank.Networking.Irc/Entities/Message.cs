namespace Frank.Networking.Irc.Entities;

public class Message : Entity
{
    public long UserId { get; set; }
    public long ChannelId { get; set; }
    public string Content { get; set; }
    public string Type { get; set; }

    public DateTime Sent { get; set; }
}