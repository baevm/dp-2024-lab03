namespace MessageDecorator;

public interface IMessage
{
    void Print();
}

public class Message : IMessage
{
    public string Text;

    public Message(string text)
    {
        Text = text;
    }

    public virtual void Print()
    {
        Console.WriteLine(Text);
    }
}
