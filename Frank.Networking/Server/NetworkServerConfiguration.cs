using Frank.Networking.Client;
using Frank.Networking.Common;

namespace Frank.Networking.Server;

public class NetworkServerConfiguration : NetworkConfiguration
{
    public int BufferSize { get; set; } = 4096;
}