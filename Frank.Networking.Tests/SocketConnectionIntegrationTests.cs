using System.Net;
using System.Net.Sockets;
using System.Text;

using Frank.Networking;

using Microsoft.Extensions.Options;

using Xunit.Abstractions;

namespace Frank.Networking.Tests;


public class ConnectionTests
{
    private readonly ITestOutputHelper _output;

    public ConnectionTests(ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    public async Task TestConnection()
    {
        // Arrange
        var options = Options.Create(new ConnectionOptions
        {
            IPAddress = IPAddress.Loopback,
            Port = 5000,
            AddressFamily = AddressFamily.InterNetwork,
            SocketType = SocketType.Stream,
            ProtocolType = ProtocolType.Tcp
        });

        var packetHandlers = new List<IPacketHandler>
        {
            new TestPacketHandler(_output)
        };

        var connection = new Connection(options.Value, packetHandlers);

        // Act
        await Task.Run(async () => await connection.ListenAsync());
        await connection.SendAsync(Encoding.UTF8.GetBytes("Hello World!"));

        // Assert
        Assert.True(true);
    }

    private class TestPacketHandler : IPacketHandler
    {
        private readonly ITestOutputHelper _output;

        public TestPacketHandler(ITestOutputHelper output)
        {
            _output = output;
        }

        public async Task HandleAsync(MemoryStream stream)
        {
            var data = stream.ToArray();
            var message = Encoding.UTF8.GetString(data);
            _output.WriteLine(message);
        }
    }
}


public interface IPacketHandler
{
    Task HandleAsync(MemoryStream stream);
}

public class Connection
{
    private readonly Socket _socket;
    private readonly IEnumerable<IPacketHandler> _packetHandlers;

    public Connection(ConnectionOptions options, IEnumerable<IPacketHandler> packetHandlers)
    {
        var socket = new Socket(options.AddressFamily, options.SocketType, options.ProtocolType);
        socket.Bind(new IPEndPoint(options.IPAddress, options.Port));
        _socket = socket;
        _packetHandlers = packetHandlers;
    }

    public async Task ListenAsync()
    {
        _socket.Listen(10);

        while (true)
        {
            var client = await _socket.AcceptAsync();
            var stream = new MemoryStream();
            var buffer = new byte[1024];

            while (true)
            {
                var receivedDataLength = await client.ReceiveAsync(new ArraySegment<byte>(buffer), SocketFlags.None);
                await stream.WriteAsync(buffer.AsMemory(0, receivedDataLength));

                if (receivedDataLength < buffer.Length)
                {
                    break;
                }
            }

            foreach (var packetHandler in _packetHandlers)
            {
                await packetHandler.HandleAsync(stream);
            }
        }
    }

    public async Task SendAsync(byte[] data) => await _socket.SendAsync(new ArraySegment<byte>(data), SocketFlags.None);
}

/// <summary>
/// Represents the options for a socket connection.
/// </summary>
public class ConnectionOptions
{
    /// <summary>
    /// Gets or sets the IP address to use for the socket connection.
    /// </summary>
    /// <value>The IP address to use for the socket connection.</value>
    public IPAddress IPAddress { get; set; }


    /// <summary>
    /// Gets or sets the port number to use for the socket connection.
    /// </summary>
    /// <value>The port number to use for the socket connection.</value>
    public int Port { get; set; }

    /// <summary>
    /// Gets or sets the address family to use for the socket connection.
    /// </summary>
    /// <value>The address family to use for the socket connection.</value>
    public AddressFamily AddressFamily { get; set; }
    

    /// <summary>
    /// Gets or sets the type of socket to use for the connection.
    /// </summary>
    /// <value>The type of socket to use for the connection.</value>
    public SocketType SocketType { get; set; }

    /// <summary>
    /// Gets or sets the protocol type to use for the socket connection.
    /// </summary>
    public ProtocolType ProtocolType { get; set; }
}