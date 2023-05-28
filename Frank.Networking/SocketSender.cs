using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Frank.Networking;

public class SocketSender : ISocketSender
{
    private readonly ILogger<SocketSender> _logger;
    private readonly IOptions<SocketConnectionOptions> _options;

    public SocketSender(ILogger<SocketSender> logger, IOptions<SocketConnectionOptions> options)
    {
        _logger = logger;
        _options = options;
    }

    public async Task SendAsync(byte[] data) => await SendAsyncInternal(data, _options.Value);

    public async Task SendAsync(byte[] data, SocketConnectionOptions options) => await SendAsyncInternal(data, options);

    private async Task SendAsyncInternal(byte[] data, SocketConnectionOptions options)
    {
        try
        {
            var socketConnection = new SocketConnection(options);
            await socketConnection.SendAsync(data);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error sending message: {ExceptionMessage}", ex.Message);
        }
    }
}