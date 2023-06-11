namespace Frank.Networking.Legacy;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddSocketListener(this IServiceCollection services, SocketListenerOptions options)
    {
        services.AddSingleton<IOptions<SocketListenerOptions>>(Options.Create(options));
        services.AddSingleton<ISocketDataReceivedHandler, SocketDataReceivedHandler>();
        services.AddHostedService<SocketListener>();
        return services;
    }
    
    public static IServiceCollection AddSocketSender(this IServiceCollection services, SocketConnectionOptions options)
    {
        services.AddTransient<ISocketSender, SocketSender>();
        services.AddSingleton<IOptions<SocketConnectionOptions>>(Options.Create(options));
        return services;
    }
}