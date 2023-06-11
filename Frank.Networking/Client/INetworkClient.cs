namespace Frank.Networking.Client;

public interface INetworkClient
{
    Task SendAsync(ReadOnlyMemory<Byte> data, CancellationToken cancellationToken);
}