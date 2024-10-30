
using System.Text;

namespace MessageDecorator;

/// <summary>
/// Декоратор сообщений в base64 кодировке
/// </summary>
public class MessageInBase64 : MessageDecorator
{
    public MessageInBase64(IMessage message) : base(message)
    {
    }

    public override void Print()
    {
        var originalMessage = CatchOriginalOutput();

        string encodedText = StrToBase64(originalMessage);

        Console.WriteLine(encodedText);
    }

    /// <summary>
    /// Метод перехвата оригинального Print()
    /// </summary>
    /// <returns></returns>
    private string CatchOriginalOutput()
    {
        TextWriter originalOut = Console.Out;

        var stringBuilder = new StringBuilder();
        var stringWriter = new StringWriter(stringBuilder);

        Console.SetOut(stringWriter);

        base.Print();

        Console.SetOut(originalOut);

        return stringBuilder.ToString();
    }

    /// <summary>
    /// Метод конвертирования строки в base64 строку
    /// </summary>
    /// <param name="value">Оригинальная строка</param>
    /// <returns></returns>
    private string StrToBase64(string value)
    {
        return Convert.ToBase64String(Encoding.UTF8.GetBytes(value));
    }
}