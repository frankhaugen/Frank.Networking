namespace Frank.Networking.Server;

public interface IOnDataReceivedHandler
{
    /// <summary>
    /// Called when data is received by the server.
    /// </summary>
    /// <param name="data"></param>
    /// <param name="cancellationToken"></param>
    /// <returns>Possible response if one should be made</returns>
    Task<ReadOnlyMemory<byte>> OnDataReceivedAsync(ReadOnlyMemory<byte> data, CancellationToken cancellationToken);
}