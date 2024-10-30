namespace MessageDecorator;


/// <summary>
/// Декоратор сообщений с датой
/// </summary>
public class MessageWithDate : MessageDecorator
{
    private readonly DateTime _date;

    public MessageWithDate(IMessage message, DateTime date) : base(message)
    {
        _date = date;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine(_date.ToString("dd.MM.yyyy"));
    }
}
