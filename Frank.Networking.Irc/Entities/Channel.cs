namespace Frank.Networking.Irc.Entities;

public class Channel : Entity
{
    /// <summary>
    /// The name of the channel.
    /// If the channel is a user channel, the name is the ids of the two users combined.
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// The topic of the channel.
    /// </summary>
    public string? Topic { get; set; }
    
    /// <summary>
    /// If true, the channel is a user channel, otherwise it is a server channel.
    /// User channels are channels that are created between two users.
    /// </summary>
    public bool IsUserChannel { get; set; }
    
    /// <summary>
    /// The password hash of the channel.
    /// </summary>
    public string? PasswordHash { get; set; }
    
    /// <summary>
    /// The date and time the channel was created.
    /// </summary>
    public DateTime Created { get; set; }
}