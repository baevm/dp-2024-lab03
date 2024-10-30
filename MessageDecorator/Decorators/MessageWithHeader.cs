namespace MessageDecorator;

/// <summary>
/// Декоратор сообщений с заголовком
/// </summary>
public class MessageWithHeader : MessageDecorator
{
    public MessageWithHeader(Messager message, string header) : base(FormatMessage(message, header))
    {
    }

    private static string FormatMessage(Messager message, string header)
    {
        return $"{header}\n{message._text}";
    }
}
