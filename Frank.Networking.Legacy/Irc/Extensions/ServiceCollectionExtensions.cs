using Frank.Networking.Legacy.Irc.Commands;
using Frank.Networking.Legacy.Irc.Server;

namespace Frank.Networking.Legacy.Irc.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddIrcCommand<T>(this IServiceCollection services) where T : class, IIrcCommand => services.AddTransient<IIrcCommand, T>();
    
    
    
    public static IServiceCollection AddIrcServer(this IServiceCollection services)
    {
        services.AddSingleton<ISocketConnectionHandler, IrcSocketHandler>();
        return services.AddTransient<IIrcServer, IrcServer>();
    }
}