namespace MessageDecorator;

class Program
{
    public static void Main(string[] args)
    {
        IMessage message = new Message("С наступающим Новым годом!");

        IMessage msgWithHeader = new MessageWithHeader(message, "Добрый день,");

        IMessage msgWithHeaderAndFooter = new MessageWithFooter(msgWithHeader, "Дед Мороз");

        IMessage msgWithHeaderFooterAndDate = new MessageWithDate(msgWithHeaderAndFooter, new DateTime(2020, 12, 26));

        IMessage msgWithHeaderFooterDateInBase64 = new MessageInBase64(msgWithHeaderFooterAndDate);

        msgWithHeaderFooterDateInBase64.Print();

        Console.WriteLine("----Проверка декораторов----");
        message.Print();
        System.Console.WriteLine();
        msgWithHeader.Print();
        System.Console.WriteLine();
        msgWithHeaderAndFooter.Print();
        System.Console.WriteLine();
        msgWithHeaderFooterAndDate.Print();
    }
}


