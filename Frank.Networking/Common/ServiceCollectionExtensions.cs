using Frank.Networking.Client;
using Frank.Networking.Server;

using Microsoft.Extensions.DependencyInjection;

namespace Frank.Networking.Common;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddNetworkServer<THandler>(this IServiceCollection serviceCollection, Action<NetworkServerConfiguration> configuration) where THandler : class, IOnDataReceivedHandler
    {
        serviceCollection.Configure(configuration);
        serviceCollection.AddSingleton<IOnDataReceivedHandler, THandler>();
        serviceCollection.AddHostedService<NetworkServer>();
        
        return serviceCollection;
    }
    
    public static IServiceCollection AddNetworkClient(this IServiceCollection serviceCollection, Action<NetworkClientConfiguration> configuration)
    {
        serviceCollection.Configure(configuration);
        serviceCollection.AddSingleton<INetworkClient, NetworkClient>();
        return serviceCollection;
    }
}