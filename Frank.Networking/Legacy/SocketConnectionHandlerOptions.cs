namespace Frank.Networking.Legacy;

public readonly record struct SocketConnectionHandlerOptions(int Port, int Backlog = 50, int MaxConnections = 1000);