// Вкладена обробка помилок в C# включає в себе використання вкладених блоків try...catch.
// Це означає, що ви можете розмістити один блок try...catch всередині іншого.
// Це дозволяє обробляти помилки на різних рівнях коду та вживати
// різні заходи у випадку виникнення виняткових ситуацій.

try
{
    throw new CustomException();
}
catch (CustomException exception)
{
    Console.WriteLine("Обробка виключення!");
    Console.WriteLine(exception.Message);
    exception.Method();

    try
    {
        FileStream fs = File.Open(@"C:\NonExistentFile.log", FileMode.OpenOrCreate);
    }
    catch (Exception innerException)
    {
        Console.WriteLine("Обробка вкладенного виключення!");
        Console.WriteLine(innerException.Message);
    }
}

Console.WriteLine("Continuation of work");

class CustomException : Exception
{
    public CustomException() { }

    public CustomException(string message) : base(message) { }

    public CustomException(string message, Exception innerException) : base(message, innerException) { }

    public void Method()
    {
        Console.WriteLine("Method from custom exception");
    }
}