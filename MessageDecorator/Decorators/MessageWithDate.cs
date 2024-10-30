namespace MessageDecorator;


/// <summary>
/// Декоратор сообщений с датой
/// </summary>
public class MessageWithDate : MessageDecorator
{
    public MessageWithDate(Messager message, DateTime date) : base(FormatMessage(message, date))
    {
    }

    private static string FormatMessage(Messager message, DateTime date)
    {
        return $"{message._text}\n{date:dd.MM.yyyy}";
    }
}
