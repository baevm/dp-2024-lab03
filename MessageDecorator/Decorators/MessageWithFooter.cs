namespace MessageDecorator;


/// <summary>
/// Декоратор сообщений с подписью
/// </summary>
public class MessageWithFooter : MessageDecorator
{
    public MessageWithFooter(Messager message, string footerMessage) : base(FormatMessage(message, footerMessage))
    {
    }

    private static string FormatMessage(Messager message, string footer)
    {
        return $"{message._text}\n{footer}";
    }
}
