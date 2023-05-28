namespace Frank.IRC.Models;

public class ChannelInfo
{
    /// <summary>
    /// The name of the channel.
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// The topic of the channel.
    /// </summary>
    public string? Topic { get; set; }

    /// <summary>
    /// The date and time the channel was created.
    /// </summary>
    public DateTime Created { get; set; }

    /// <summary>
    /// The messages in the channel.
    /// </summary>
    public IEnumerable<MessageInfo> Messages { get; set; }
    
    /// <summary>
    /// The users in the channel.
    /// </summary>
    public IEnumerable<UserInfo> Users { get; set; }
}

public class MessageInfo
{
    /// <summary>
    /// The id of the user that sent the message.
    /// </summary>
    public long UserId { get; set; }
    
    /// <summary>
    /// The id of the channel the message was sent in.
    /// </summary>
    public long ChannelId { get; set; }
    
    /// <summary>
    /// The content of the message.
    /// </summary>
    public string Content { get; set; }
    
    /// <summary>
    /// The type of the message.
    /// </summary>
    /// <remarks>
    /// The type of the message is used to determine how the message should be displayed.
    /// </remarks>
    public string Type { get; set; }

    /// <summary>
    /// The date and time the message was sent.
    /// </summary>
    public DateTime Sent { get; set; }
}