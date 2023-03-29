using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Frank.Networking;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddSocketListener(this IServiceCollection services, SocketListenerOptions options)
    {
        services.AddSingleton<IOptions<SocketListenerOptions>>(Options.Create(options));
        services.AddSingleton<ISocketDataReceivedHandler, SocketDataReceivedHandler>();
        services.AddHostedService<SocketListener>();
        return services;
    }
    
    public static IServiceCollection AddSocketSender(this IServiceCollection services, SocketSenderOptions options)
    {
        services.AddTransient<ISocketSender, SocketSender>();
        services.AddSingleton<IOptions<SocketSenderOptions>>(Options.Create(options));
        return services;
    }
}