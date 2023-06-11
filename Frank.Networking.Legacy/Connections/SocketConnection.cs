namespace Frank.Networking.Legacy.Connections;

public class SocketConnection<TConfig, TPort>
    where TConfig : SocketConfiguration<TPort>
    where TPort : Port
{
    private readonly IOptions<TConfig> _options;
    private readonly ILogger<SocketConnection<TConfig, TPort>> _logger;
    private readonly Socket _socket;
    private readonly ISocketDataReceivedHandler<TConfig, TPort> _handler;

    public SocketConnection(IOptions<TConfig> options, ILogger<SocketConnection<TConfig, TPort>> logger, ISocketDataReceivedHandler<TConfig, TPort> handler)
    {
        _options = options;
        _logger = logger;
        _handler = handler;
        _socket = new Socket(_options.Value.AddressFamily, _options.Value.SocketType, _options.Value.ProtocolType);
    }

    public bool IsConnected => _socket?.Connected ?? false;

    public async Task ConnectAsync(CancellationToken cancellationToken)
    {
        if (_socket == null)
        {
            _logger.LogError("Socket is null");
            throw new InvalidOperationException("Socket is null");
        }

        try
        {
            await _socket.ConnectAsync(_options.Value.Address, _options.Value.Port.Number, cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to connect to socket");
            throw;
        }

        try
        {
            await ReceiveAsync(cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to start listening for data");
            throw;
        }
    }

    public void Disconnect()
    {
        if (_socket == null)
        {
            _logger.LogError("Socket is null");
            throw new InvalidOperationException("Socket is null");
        }

        if (!IsConnected)
        {
            _logger.LogError("Socket is not connected");
            throw new InvalidOperationException("Socket is not connected");
        }

        try
        {
            _socket.Disconnect(true);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to disconnect from socket");
            throw;
        }
    }

    public async Task SendAsync(byte[] data, CancellationToken cancellationToken)
    {
        if (_socket == null)
        {
            _logger.LogError("Socket is null");
            throw new InvalidOperationException("Socket is null");
        }

        if (!IsConnected)
        {
            _logger.LogError("Socket is not connected");
            throw new InvalidOperationException("Socket is not connected");
        }

        try
        {
            await _socket.SendAsync(new ArraySegment<byte>(data), SocketFlags.None);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to send data to socket");
            throw;
        }
    }

    private async Task ReceiveAsync(CancellationToken cancellationToken)
    {
        var buffer = new byte[1024];
        while (!cancellationToken.IsCancellationRequested)
        {
            var result = await _socket.ReceiveAsync(new ArraySegment<byte>(buffer), SocketFlags.None, cancellationToken);
            if (result > 0)
            {
                try
                {
                    await _handler.OnDataReceivedAsync(new ReadOnlyMemory<byte>(buffer, 0, result), cancellationToken);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Failed to handle received data");
                    throw;
                }
            }
        }
    }
}
