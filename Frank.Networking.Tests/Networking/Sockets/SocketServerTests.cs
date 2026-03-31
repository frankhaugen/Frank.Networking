using System.Net;
using System.Net.Sockets;
using System.Text;

using Xunit.Abstractions;

namespace Frank.IRC.Tests.Networking.Sockets;

public class SocketServerTests
{
    private const int TestPort = 8888;
    private readonly ITestOutputHelper _outputHelper;

    public SocketServerTests(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
    }

    [Fact]
    public async Task SocketServer_ClientConnects_Success()
    {
        // Arrange
        var server = new SocketServer(IPAddress.Loopback, TestPort, _outputHelper);
        server.Start();

        // Act
        using var client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        await client.ConnectAsync(IPAddress.Loopback, TestPort);
        bool isConnected = client.Connected;
        await client.SendAsync(Encoding.UTF8.GetBytes("Hello World"), SocketFlags.None);

        // Assert
        Assert.True(isConnected);

        // Cleanup
        server.Stop();
    }
    
    
    public class SocketServer
    {
        private readonly IPAddress _ipAddress;
        private readonly int _port;
        private Socket _listener;
        private CancellationTokenSource _cancellationTokenSource;
        private readonly ITestOutputHelper _outputHelper;
    
        public SocketServer(IPAddress ipAddress, int port, ITestOutputHelper outputHelper)
        {
            _ipAddress = ipAddress;
            _port = port;
            _outputHelper = outputHelper;
        }

        public void Start()
        {
            _listener = new Socket(_ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            _listener.Bind(new IPEndPoint(_ipAddress, _port));
            _listener.Listen(10);

            _cancellationTokenSource = new CancellationTokenSource();
            Task.Run(() => AcceptClientsAsync(_cancellationTokenSource.Token));
        }

        private async Task AcceptClientsAsync(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                try
                {
                    var client = await _listener.AcceptAsync(cancellationToken);
                    _ = Task.Run(() => HandleClientAsync(client, cancellationToken), cancellationToken);
                }
                catch (Exception ex)
                {
                    // Handle exceptions, log errors, or perform necessary cleanup.
                    _outputHelper.WriteLine(ex.Message);
                }
            }
        }

        private async Task HandleClientAsync(Socket client, CancellationToken cancellationToken)
        {
            using (client)
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    try
                    {
                        byte[] buffer = new byte[1024];
                        int bytesRead = await client.ReceiveAsync(buffer, SocketFlags.None);
                        if (bytesRead == 0) break; // Connection closed by client.

                        // Process the received data.
                        string receivedData = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        _outputHelper.WriteLine($"Received: {receivedData}");

                        // Send a response to the client.
                        byte[] responseData = Encoding.UTF8.GetBytes($"Echo: {receivedData}");
                        await client.SendAsync(responseData, SocketFlags.None);
                    }
                    catch (Exception ex)
                    {
                        // Handle exceptions, log errors, or perform necessary cleanup.
                        _outputHelper.WriteLine(ex.Message);
                    }
                }
            }
        }

        public void Stop()
        {
            _cancellationTokenSource.Cancel();
            _listener.Close();
        }
    }
}