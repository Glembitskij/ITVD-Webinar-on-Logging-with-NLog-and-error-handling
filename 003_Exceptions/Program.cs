// Обробка винятків
// Ключове слово throw використовується для генерації виняткової ситуації у програмі.
// Коли виникає ситуація, яка вимагає викидання помилки, можна скористатися throw
// для створення та викидання об'єкта винятку.

Cat vasa = new Cat();

//vasa.Life(200);

try
{
    vasa.Life(200);
}
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