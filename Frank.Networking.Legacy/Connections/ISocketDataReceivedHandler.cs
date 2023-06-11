namespace Frank.Networking.Legacy.Connections;

public interface ISocketDataReceivedHandler<TConfig, TPort>
    where TConfig : SocketConfiguration<TPort>
    where TPort : Port
{
    Task OnDataReceivedAsync(ReadOnlyMemory<byte> data, CancellationToken cancellationToken);
}