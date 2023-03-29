using System.Net;
using System.Net.Sockets;

namespace Frank.Networking.Legacy;

public readonly record struct SocketInfo(AddressFamily AddressFamily, SocketType SocketType, ProtocolType ProtocolType, IPEndPoint EndPoint);