using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Frank.Networking;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddTcpServer(this IServiceCollection services, SocketListenerOptions options)
    {
        services.AddSingleton<IOptions<SocketListenerOptions>>(Options.Create(options));
        services.AddSingleton<ISocketDataReceivedHandler, SocketDataReceivedHandler>();
        services.AddHostedService<SocketListener>();
        return services;
    }
    
}