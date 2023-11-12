// NLog - це потужна бібліотека для логування в програмах на мові C#
// та інших платформах .NET. Вона надає можливість здійснювати розширений контроль
// над логуванням додатка, дозволяючи настроювати формат запису логів,
// визначати різні цільові місця для логів (файли, бази даних, консоль і т. д.),
// а також використовувати різні рівні логування.

using NLog;

class Program
{
    private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
    static void Main()
    {
        try
        {
            // Приклад логування
            Logger.Info("Застосунок запущено");
            Logger.Debug("Це повідомлення для відладки");
            Logger.Error("Це приклад помилки");

            throw new CustomException("Custom exception");

        }
        catch (Exception ex)
        {
            Logger.Error(ex, "Виникла помилка");
        }
        finally
        {
            LogManager.Shutdown();
        }
    }

}

public class CustomException : Exception
{
    public CustomException() { }
    public CustomException(string message) : base(message) { }

    public void Method()
    {
        Console.WriteLine("Method from custom exception");
    }
}
