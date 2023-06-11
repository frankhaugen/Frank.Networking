namespace Frank.Networking.Legacy.Connections
{
    public static class SocketConnectionExtensions
    {
        public static IServiceCollection AddSocketConnection<TConfig, TPort, THandler>(this IServiceCollection services, Action<TConfig> configure)
            where TConfig : SocketConfiguration<TPort>
            where TPort : Port, new()
            where THandler : class, ISocketDataReceivedHandler<TConfig, TPort>
        {
            services.Configure(configure);
            services.AddSingleton<ISocketDataReceivedHandler<TConfig, TPort>, THandler>();
            services.AddSingleton<SocketConnection<TConfig, TPort>>();
            return services;
        }
    }
}