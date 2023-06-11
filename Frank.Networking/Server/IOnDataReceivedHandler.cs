namespace Frank.Networking.Server;

public interface IOnDataReceivedHandler
{
    Task OnDataReceivedAsync(ReadOnlyMemory<byte> data, CancellationToken cancellationToken);
}