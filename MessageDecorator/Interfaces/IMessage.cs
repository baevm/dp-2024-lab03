namespace MessageDecorator;

public interface IMessage
{
    void Print();
}

public abstract class Messager : IMessage
{
    public readonly string _text;

    public Messager(string text)
    {
        _text = text;
    }

    public void Print()
    {
        Console.WriteLine(_text);
    }
};