// Блок finally в мові програмування C# використовується разом з блоком try...catch
// і дозволяє визначити код, який буде виконаний завжди, незалежно від того,
// чи виникали винятки в блоках try або catch. Код у блоку finally виконується після того,
// як виконується код у блокі try або після обробки винятків у блоках catch,
// і він викликається навіть у випадку виникнення виняткової ситуації.

try
{
    // Виклик методу, який може викинути виняток
    ProcessData(0);
}
catch (CustomException ex)
{
    Console.WriteLine("Обробка користувацького винятку в блоку catch:");
    Console.WriteLine("Помилка: " + ex.Message);
}
finally
{
    // Код, який виконається завжди, незалежно від того, чи виникли винятки
    Console.WriteLine("Блок finally виконався.");
}

static void ProcessData(int value)
{
    // Перевірка умови та викидання користувацького винятку
    if (value == 0)
    {
        throw new CustomException("Значення не може бути рівним нулю.");
    }

    // Інший код обробки даних
}

public class CustomException : Exception
{
    public CustomException() { }
    public CustomException(string message) : base(message) { }
}