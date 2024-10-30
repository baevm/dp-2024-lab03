
using System.Text;

namespace MessageDecorator;

/// <summary>
/// Декоратор сообщений в base64 кодировке
/// </summary>
public class MessageInBase64 : MessageDecorator
{
    public MessageInBase64(Messager message) : base(FormatMessage(message))
    {
    }

    private static string FormatMessage(Messager message)
    {
        return Convert.ToBase64String(Encoding.UTF8.GetBytes(message._text));
    }
}