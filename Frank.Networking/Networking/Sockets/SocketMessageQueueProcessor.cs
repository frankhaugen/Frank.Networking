using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Frank.IRC.Networking.Sockets;

public class SocketMessageQueueProcessor : BackgroundService
{
    private readonly ISocketMessageQueue _queue;
    private readonly IEnumerable<ISocketMessageHandler> _handlers;
    private readonly ILogger<SocketMessageQueueProcessor> _logger;

    public SocketMessageQueueProcessor(ISocketMessageQueue queue, IEnumerable<ISocketMessageHandler> handlers, ILogger<SocketMessageQueueProcessor> logger)
    {
        _queue = queue;
        _handlers = handlers;
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("SocketMessageQueueProcessor is starting.");
        
        while (!stoppingToken.IsCancellationRequested)
        {
            var message = _queue.Dequeue();
            if (message is null)
            {
                await Task.Delay(100, stoppingToken);
                continue;
            }
            
            _logger.LogDebug("Handling message {Message} on port {Port}", message.Message, message.Port);
            
            var handler = _handlers?.FirstOrDefault(x => x.Port == message.Port);
            if (handler is null)
            {
                _logger.LogWarning("No handler found for port {Port}", message.Port);
                continue;
            }

            try
            {
                await handler.HandleAsync(message, stoppingToken);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Error handling message, requeuing");
                _queue.Enqueue(message);
            }
        }
        
        _logger.LogInformation("SocketMessageQueueProcessor is stopping.");
    }
}