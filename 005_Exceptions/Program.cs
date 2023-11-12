// Обробка винятків
// Створення користувацьких класів винятків в C# дозволяє вам визначити свої типи винятків,
// що відображають конкретні ситуації або помилки в вашому програмному коді.
// Це корисно для забезпечення зрозумілості та точності обробки помилок у вашому додатку

Cat vasa = new Cat();

//vasa.Life(200);

try
{
    if (DateTime.Now.Ticks % 2 == 0) 
    {
        vasa = null;
    }

    vasa.Life(200);
}
// Пробема, блок catch обробляє 2 типи помилок.
// Вирішення, створення свого користувацького классу обробки помилок.
catch (Exception exception)
{
    Console.WriteLine(exception.Message);
}

Console.WriteLine("Continuation of work");

class Cat
{
    public void Life(int puls)
    {
        if (puls < 50 || puls > 150)
        {
            Exception exception = new Exception("Error, cat death :(");
            throw exception;
        }
    }
}