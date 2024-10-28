namespace MessageDecorator;

public abstract class MessageDecorator : IMessage
{
    private IMessage _message;

    public MessageDecorator(IMessage message)
    {
        _message = message;
    }

    public virtual void Print()
    {
        _message.Print();
    }
}
