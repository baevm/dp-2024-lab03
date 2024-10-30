namespace MessageDecorator;

public abstract class MessageDecorator : IMessage
{
    private readonly IMessage _message;

    protected MessageDecorator(IMessage message)
    {
        _message = message;
    }

    public virtual void Print()
    {
        _message.Print();
    }
}
