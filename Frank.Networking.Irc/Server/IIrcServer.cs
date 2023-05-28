namespace Frank.Networking.Irc.Server;

public interface IIrcServer
{
    Task ReceiveCommandAsync(IIrcCommand command);
}