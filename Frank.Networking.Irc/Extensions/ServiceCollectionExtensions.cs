using Frank.Networking.Irc.Server;

using Microsoft.Extensions.DependencyInjection;

namespace Frank.Networking.Irc.Helpers;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddIrcCommand<T>(this IServiceCollection services) where T : class, IIrcCommand => services.AddTransient<IIrcCommand, T>();
    
    
    
    public static IServiceCollection AddIrcServer(this IServiceCollection services)
    {
        services.AddSingleton<ISocketConnectionHandler, IrcSocketHandler>();
        return services.AddTransient<IIrcServer, IrcServer>();
    }
}