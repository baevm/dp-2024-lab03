namespace MessageDecorator;

/// <summary>
/// Декоратор сообщений с заголовком
/// </summary>
public class MessageWithHeader : MessageDecorator
{
    private readonly string _header;

    public MessageWithHeader(IMessage message, string header) : base(message)
    {
        _header = header;
    }

    public override void Print()
    {
        Console.WriteLine(_header);
        base.Print();
    }
}
