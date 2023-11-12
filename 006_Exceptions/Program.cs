// Обробка винятків
// Створення користувацьких класів винятків в C# дозволяє вам визначити свої типи винятків,
// що відображають конкретні ситуації або помилки в вашому програмному коді.
// Це корисно для забезпечення зрозумілості та точності обробки помилок у вашому додатку

Cat vasa = new Cat();

try
{
    if (DateTime.Now.Ticks % 2 == 0)
    {
        vasa = null;
    }

    vasa.Life(200);
}
catch (DeathCatException exception)
{
    Console.WriteLine("Death Cat Exception");
    Console.WriteLine(exception.Message);
}
catch (NullReferenceException exception)
{
    Console.WriteLine("Null Reference Exception");
    Console.WriteLine(exception.Message);
}
catch (Exception exception)
{
    Console.WriteLine("Exception");
    Console.WriteLine(exception.Message);
}

Console.WriteLine("Continuation of work");

class Cat
{
    public void Life(int puls)
    {
        if (puls < 50 || puls > 150)
        {
            DeathCatException exception = new DeathCatException("Error, cat death :(");
            throw exception;
        }
    }
}

class DeathCatException: Exception
{
    public DeathCatException() { }

    public DeathCatException(string message): base(message) {}

    public DeathCatException(string message, Exception innerException) : base(message, innerException) { }
}