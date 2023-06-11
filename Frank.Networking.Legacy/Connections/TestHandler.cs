using System.Text;

namespace Frank.Networking.Legacy.Connections;

public class TestHandler : ISocketDataReceivedHandler<TestConfiguration, TestPort>
{
    private readonly ILogger<TestHandler> _logger;

    public TestHandler(ILogger<TestHandler> logger)
    {
        _logger = logger;
    }


    public async Task OnDataReceivedAsync(ReadOnlyMemory<byte> data, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Received data: {data}", Encoding.UTF8.GetString(data.ToArray()));
        await Task.CompletedTask;
    }
}