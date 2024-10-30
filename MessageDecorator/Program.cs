namespace MessageDecorator;

class Program
{
    public static void Main(string[] args)
    {
        Messager message = new Message("С наступающим Новым годом!");

        Messager msgWithHeader = new MessageWithHeader(message, "Добрый день,");

        Messager msgWithHeaderAndFooter = new MessageWithFooter(msgWithHeader, "Дед Мороз");

        Messager msgWithHeaderFooterAndDate = new MessageWithDate(msgWithHeaderAndFooter, new DateTime(2020, 12, 26));

        Messager msgWithHeaderFooterDateInBase64 = new MessageInBase64(msgWithHeaderFooterAndDate);

        msgWithHeaderFooterDateInBase64.Print();

        Console.WriteLine("----Проверка декораторов----");
        message.Print();
        Console.WriteLine();
        msgWithHeader.Print();
        Console.WriteLine();
        msgWithHeaderAndFooter.Print();
        Console.WriteLine();
        msgWithHeaderFooterAndDate.Print();
    }
}


