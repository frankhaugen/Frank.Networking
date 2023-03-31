using System.Text;

namespace Frank.Networking.Irc.Helpers;

public static class EncodingHelper
{
    public static bool TryGetString(byte[] bytes, out string result)
    {
        try
        {
            result = Encoding.UTF8.GetString(bytes);
            return true;
        }
        catch
        {
            result = string.Empty;
            return false;
        }
    }
}