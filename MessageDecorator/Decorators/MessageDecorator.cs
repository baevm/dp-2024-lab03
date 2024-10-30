namespace MessageDecorator;

public abstract class MessageDecorator : Messager
{
    protected MessageDecorator(string message) : base(message)
    {
    }
}
