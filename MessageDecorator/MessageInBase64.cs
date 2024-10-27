
using System.Text;

namespace MessageDecorator;

public class MessageInBase64 : MessageDecorator
{
    public MessageInBase64(IMessage message) : base(message)
    {
    }

    public override void Print()
    {
        TextWriter originalOut = Console.Out;

        var stringBuilder = new StringBuilder();
        var stringWriter = new StringWriter(stringBuilder);

        Console.SetOut(stringWriter);

        base.Print();

        Console.SetOut(originalOut);

        var fullMessage = stringBuilder.ToString();

        string encodedText = Convert.ToBase64String(Encoding.UTF8.GetBytes(fullMessage));
        Console.WriteLine(encodedText);
    }
}