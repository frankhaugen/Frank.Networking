using System.Reflection;

using Microsoft.Extensions.DependencyInjection;

namespace Frank.IRC.Networking.Sockets;

public static class GenericExtensions
{
    public static T Set<T>(this T obj, T value)
    {
        var type = typeof(T);
        var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
        foreach (var property in properties)
        {
            var valueProperty = value.GetType().GetProperty(property.Name);
            if (valueProperty is null)
            {
                continue;
            }
            
            var valuePropertyValue = valueProperty.GetValue(value);
            property.SetValue(obj, valuePropertyValue);
        }

        return value;
    }
}

public static class ServiceCollectionExtensions
{
    internal static IServiceCollection AddSocketServer(this IServiceCollection services, SocketOptions options)
    {
        services.AddHostedService<SocketListener>();
        services.Configure<SocketOptions>(x => x.Set(options));
        return services;
    }
    
    internal static IServiceCollection AddSocketMessageQueue(this IServiceCollection services)
    {
        services.AddSingleton<ISocketMessageQueue, SocketMessageQueue>();
        services.AddHostedService<SocketMessageQueueProcessor>();
        return services;
    }
    
    internal static IServiceCollection AddSocketMessageHandler(this IServiceCollection services, ISocketMessageHandler handler)
    {
        services.AddSingleton<ISocketMessageHandler>(handler);
        return services;
    }
    
    public static IServiceCollection AddSocketServer(this IServiceCollection services, SocketOptions options, ISocketMessageHandler handler)
    {
        services.AddSocketMessageQueue();
        services.AddSocketMessageHandler(handler);
        services.AddSocketServer(options);
        return services;
    }
    
    public static IServiceCollection AddSocketClient(this IServiceCollection services, SocketOptions options)
    {
        services.AddSingleton<ISocketClient, SocketClient>();
        services.Configure<SocketOptions>(x => x.Set(options));
        return services;
    }
}