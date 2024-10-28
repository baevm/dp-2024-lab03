namespace MessageDecorator;

public class Message : IMessage
{
    private string Text;

    public Message(string text)
    {
        Text = text;
    }

    public virtual void Print()
    {
        Console.WriteLine(Text);
        
    }
}
