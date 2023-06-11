using Frank.Networking.Client;
using Frank.Networking.Common;

namespace Frank.Networking.Server;

public class NetworkServerConfiguration : NetworkConfiguration
{
    /// <summary>
    /// 4096 (4kb) is default
    /// </summary>
    public int BufferSize { get; set; } = 4096;
    
    /// <summary>
    /// True is default
    /// </summary>
    public bool SendResponse { get; set; } = true;
}