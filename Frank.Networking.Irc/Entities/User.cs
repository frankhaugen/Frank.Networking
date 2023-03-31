namespace Frank.Networking.Irc.Entities;

public class User : Entity
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Nickname { get; set; }
    public string PasswordHash { get; set; }
    public DateTime LastLogin { get; set; }
}