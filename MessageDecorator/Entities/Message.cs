namespace MessageDecorator;

public class Message : IMessage
{
    private string _text;

    public Message(string text)
    {
        _text = text;
    }

    public void Print()
    {
        Console.WriteLine(_text);
    }
}
