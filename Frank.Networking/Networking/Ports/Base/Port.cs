namespace Frank.IRC.Networking.Ports.Base;

public abstract class Port : IPort
{
    public string Name { get; }
    public int Number { get; }

    public Port(PortType portName)
    {
        Name = portName.ToString();
        Number = (int)portName;
    }
}