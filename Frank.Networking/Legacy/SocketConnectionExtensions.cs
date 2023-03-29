namespace Frank.Networking.Legacy;

public static class SocketConnectionExtensions
{
    public static async Task<bool> StartAsync(this SocketConnection connection, CancellationToken cancellationToken)
    {
        try
        {
            await connection.ConnectAsync(cancellationToken);

            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}