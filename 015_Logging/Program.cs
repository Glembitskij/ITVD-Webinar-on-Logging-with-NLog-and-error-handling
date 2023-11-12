// NLog - це потужна бібліотека для логування в програмах на мові C#
// та інших платформах .NET. Вона надає можливість здійснювати розширений контроль
// над логуванням додатка, дозволяючи настроювати формат запису логів,
// визначати різні цільові місця для логів (файли, бази даних, консоль і т. д.),
// а також використовувати різні рівні логування.

using NLog;
using NLog.Config;
using NLog.Targets;

class Program
{
    private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
    static void Main()
    {
        SetupNLog();

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

    static void SetupNLog()
    {
        // Створення конфігурації NLog програматично
        var config = new LoggingConfiguration();

        // Додавання консольного виводу
        var consoleTarget = new ColoredConsoleTarget();

        config.AddTarget("console", consoleTarget);
        config.AddRuleForAllLevels(consoleTarget);

        // Додавання файлового виводу
        var fileTarget = new FileTarget
        {
            FileName = "logfile.txt"
        };
        config.AddTarget("file", fileTarget);
        config.AddRuleForAllLevels(fileTarget);

        // Встановлення конфігурації NLog
        LogManager.Configuration = config;
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
