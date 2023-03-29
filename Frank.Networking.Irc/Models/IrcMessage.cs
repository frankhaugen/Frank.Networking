using Frank.IRC.Commands;
using Frank.IRC.Commands.Base;

namespace Frank.IRC.Models;

public class IrcMessage
{
    public CommandName Command { get; set; }
    public string[] Parameters { get; set; }
}