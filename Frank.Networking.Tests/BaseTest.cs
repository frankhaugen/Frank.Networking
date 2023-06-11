using System.Net.Sockets;

using Frank.Networking.Legacy.Connections;

using Microsoft.Extensions.DependencyInjection;

using Xunit.Abstractions;

namespace Frank.Networking.Tests;

public abstract class BaseTest
{
    private readonly ITestOutputHelper _outputHelper;

    protected BaseTest(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
    }

    protected void WriteLine(string message)
    {
        _outputHelper.WriteLine(message);
    }

    protected void WriteLine(string format, params object[] args)
    {
        _outputHelper.WriteLine(format, args);
    }

    protected void WriteLine(object obj)
    {
        _outputHelper.WriteLine(obj.ToString());
    }

    protected SocketConnection<SocketConfiguration<Port>, Port> CreateSocketConnection()
    {
        var services = new ServiceCollection();
        // services.AddLogging(builder => builder.AddXunit(_outputHelper));
        services.AddSocketConnection<TestConfiguration, TestPort, TestHandler>(config =>
        {
            config.AddressFamily = AddressFamily.InterNetwork;
            config.SocketType = SocketType.Stream;
            config.ProtocolType = ProtocolType.Tcp;
        });
        var provider = services.BuildServiceProvider();
        var connection = provider.GetRequiredService<SocketConnection<SocketConfiguration<Port>, Port>>();
        return connection;
    }
}