namespace Frank.Networking.Irc.Entities;

public class User : Entity
{
    /// <summary>
    /// The username of the user.
    /// </summary>
    public string Username { get; set; }
    
    /// <summary>
    /// The email of the user.
    /// </summary>
    public string Email { get; set; }
    
    /// <summary>
    /// The nickname of the user.
    /// </summary>
    public string Nickname { get; set; }
    
    /// <summary>
    /// The password hash of the user.
    /// </summary>
    public string PasswordHash { get; set; }
    
    /// <summary>
    /// The date and time the user last logged in.
    /// </summary>
    public DateTime LastLogin { get; set; }
}