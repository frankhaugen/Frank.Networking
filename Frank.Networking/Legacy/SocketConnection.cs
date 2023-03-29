using System.Net.Sockets;

namespace Frank.Networking.Legacy;

public class SocketConnection
{
    private readonly SocketInfo _socketInfo;
    private readonly Socket _socket;      
    
    public SocketConnection(SocketInfo socketInfo)
    {
        _socketInfo = socketInfo;
        _socket = new Socket(_socketInfo.AddressFamily, _socketInfo.SocketType, _socketInfo.ProtocolType);
    }
    
    public void Bind() 
        => _socket.Bind(_socketInfo.EndPoint);
    
    public void Listen()
        => _socket.Listen();

    public async Task ConnectAsync(CancellationToken cancellationToken) 
        => await _socket.ConnectAsync(_socketInfo.EndPoint, cancellationToken);
        
    public async Task SendAsync(byte[] data, CancellationToken cancellationToken) 
        => await _socket.SendAsync(new ArraySegment<byte>(data), SocketFlags.None, cancellationToken);
        
    public async Task AcceptAsync(CancellationToken cancellationToken) 
        => await _socket.AcceptAsync(cancellationToken);
        
    public async Task<byte[]> ReceiveAsync(CancellationToken cancellationToken)
    {
        var buffer = new byte[1024];
        var result = await _socket.ReceiveAsync(new ArraySegment<byte>(buffer), SocketFlags.None, cancellationToken);
        return buffer[..result];
    }
    
    public void Close() => _socket.Close();

    public void Dispose() => _socket.Dispose();
    
    public SocketInfo GetSocketInfo() => _socketInfo;
    
    public bool IsConnected() => _socket.Connected;
    
    public bool IsBound() => _socket.IsBound;
    
    public bool IsListening() => _socket is { IsBound: true, Connected: false };
    
    public bool IsClosed() => _socket is { IsBound: false, Connected: false };
}