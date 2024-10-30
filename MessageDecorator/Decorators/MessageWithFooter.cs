namespace MessageDecorator;


/// <summary>
/// Декоратор сообщений с подписью
/// </summary>
public class MessageWithFooter : MessageDecorator
{
    private readonly string _footer;

    public MessageWithFooter(IMessage message, string footerMessage) : base(message)
    {
        _footer = footerMessage;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine(_footer);
    }
}
