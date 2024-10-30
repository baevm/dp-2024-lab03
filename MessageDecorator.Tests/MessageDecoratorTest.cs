using System.Text;

namespace MessageDecorator.Tests;

public class MessageDecoratorTests
{
    [Fact]
    public void Test_Base_Message()
    {
        var stringBuilder = new StringBuilder();
        var stringWriter = new StringWriter(stringBuilder);

        Console.SetOut(stringWriter);

        var text = "С наступающим Новым годом!";
        IMessage message = new Message(text);

        message.Print();

        Assert.Equal(text, stringBuilder.ToString().Replace("\n", ""));
    }

    [Fact]
    public void Test_MessageWithHeader()
    {
        var stringBuilder = new StringBuilder();
        var stringWriter = new StringWriter(stringBuilder);

        Console.SetOut(stringWriter);

        var text = "С наступающим Новым годом!";
        IMessage message = new Message(text);

        var header = "Добрый день,";
        IMessage msgWithHeader = new MessageWithHeader(message, header);

        msgWithHeader.Print();

        Assert.Equal(header + text, stringBuilder.ToString().Replace("\n", ""));
    }

    [Fact]
    public void Test_MessageWithFooter()
    {
        var stringBuilder = new StringBuilder();
        var stringWriter = new StringWriter(stringBuilder);

        Console.SetOut(stringWriter);

        var text = "С наступающим Новым годом!";
        IMessage message = new Message(text);

        var footer = "Дед Мороз";
        IMessage msgWithHeader = new MessageWithFooter(message, footer);

        msgWithHeader.Print();

        Assert.Equal(text + footer, stringBuilder.ToString().Replace("\n", ""));
    }

    [Fact]
    public void Test_MessageWithDate()
    {
        var stringBuilder = new StringBuilder();
        var stringWriter = new StringWriter(stringBuilder);

        Console.SetOut(stringWriter);

        var text = "С наступающим Новым годом!";
        IMessage message = new Message(text);

        var date = new DateTime(2020, 12, 26);
        IMessage msgWithDate = new MessageWithDate(message, date);

        msgWithDate.Print();

        Assert.Equal(text + "26.12.2020", stringBuilder.ToString().Replace("\n", ""));
    }


    [Fact]
    public void Test_MessageInBase64()
    {
        var stringBuilder = new StringBuilder();
        var stringWriter = new StringWriter(stringBuilder);

        Console.SetOut(stringWriter);

        var text = "С наступающим Новым годом!";
        IMessage message = new Message(text);

        IMessage msgInBase64 = new MessageInBase64(message);

        msgInBase64.Print();

        var expectedBase64Text = Convert.ToBase64String(Encoding.UTF8.GetBytes(text + "\n"));

        Assert.Equal(expectedBase64Text, stringBuilder.ToString().Replace("\n", ""));
    }

    [Fact]
    public void Test_MessageWithHeaderFooterDateInBase64()
    {
        var stringBuilder = new StringBuilder();
        var stringWriter = new StringWriter(stringBuilder);

        Console.SetOut(stringWriter);

        IMessage message = new Message("С наступающим Новым годом!");
        IMessage msgWithHeader = new MessageWithHeader(message, "Добрый день,");
        IMessage msgWithHeaderAndFooter = new MessageWithFooter(msgWithHeader, "Дед Мороз");
        IMessage msgWithHeaderFooterAndDate = new MessageWithDate(msgWithHeaderAndFooter, new DateTime(2020, 12, 26));
        
        IMessage msgWithHeaderFooterDateInBase64 = new MessageInBase64(msgWithHeaderFooterAndDate);

        msgWithHeaderFooterDateInBase64.Print();

        var expectedText = $"Добрый день,\nС наступающим Новым годом!\nДед Мороз\n26.12.2020\n";
        var expectedBase64Text = Convert.ToBase64String(Encoding.UTF8.GetBytes(expectedText));

        Assert.Equal(expectedBase64Text, stringBuilder.ToString().Replace("\n", ""));
    }
}