namespace Frank.Networking.Irc.Entities;

public class ChannelUser : Entity
{
    public long ChannelId { get; set; }
    public long UserId { get; set; }
    public string Nickname { get; set; }
    public string Username { get; set; }
    public string Hostname { get; set; }
    public string Mode { get; set; }
    public DateTime Joined { get; set; }
}