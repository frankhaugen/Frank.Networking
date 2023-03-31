namespace Frank.Networking.Irc.Entities;

public class Channel : Entity
{
    public string Name { get; set; }
    public string Topic { get; set; }
    // public string PasswordHash { get; set; }
    public DateTime Created { get; set; }
}