namespace Frank.Networking.Legacy.Connections;

/// <summary> Represents a port. Intended to be used with <see cref="SocketConfiguration{T}"/>.
/// <para> This class is abstract. </para>
/// This is meant to be implemented by the user to provide a port number and name. Note that the name is optional.
/// </summary>
public abstract class Port
{
    /// <summary> Gets or sets the port number. </summary>
    public abstract int Number { get; set; }

    /// <summary> Gets or sets the port name. </summary>
    public string Name { get; set; } = string.Empty;
}