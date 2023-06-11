using Microsoft.Extensions.Hosting;

namespace Frank.Networking.Legacy.Connections;

public static class Program
{
    public static async Task Main(string[] args)
    {
        using var host = GetHost();
        await host.RunAsync();
    }

    static IHost GetHost() => Host.CreateDefaultBuilder()
        .ConfigureServices((hostContext, services) =>
        {
            services.AddHostedService<TestWorker>();
            services.AddLogging();
            services.AddSocketConnection<TestConfiguration, TestPort, TestHandler>(options =>
            {
                options.Port = new TestPort();
                options.AddressFamily = AddressFamily.InterNetwork;
                options.SocketType = SocketType.Stream;
                options.ProtocolType = ProtocolType.Tcp;
                options.Address = IPAddress.Loopback;
            });
        })
        .Build();
}