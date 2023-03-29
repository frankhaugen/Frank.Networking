using Microsoft.Extensions.DependencyInjection;

namespace Frank.Networking;

public static class DependencyInjectionExtensions
{
    public static IServiceCollection AddSocketClient(this IServiceCollection services, SocketClientOptions options)
    {
        services.AddTransient<ISocketClient, SocketClient>();
        //services.AddSingleton<IOptions<SocketClientOptions>>(Options.Create(options));
        return services;
    }
}