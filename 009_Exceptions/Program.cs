// Обработка виключення, вкладенний try - catch, порядок роботи.

try
{
    CustomException customerExp = new CustomException();
    throw customerExp;
}
catch (CustomException customerExp)
{
    Console.WriteLine("Обробка першого виключення (1-ше):");
    customerExp.Method();

    try
    {
        throw new Exception();
    }
    catch (Exception exception)
    {
        Console.WriteLine("Обробка другого виключення (2-ге):");
        Console.WriteLine(exception.Message);
    }
    finally
    {
        Console.WriteLine("finally відпрацювое завжди!(1-й раз)");
    }
}
finally
{
    Console.WriteLine("finally відпрацювое завжди!(2-й раз)");
}

Console.WriteLine("Continuation of work");


public class CustomException : Exception
{
    public CustomException() { }
    public CustomException(string message) : base(message) { }

    public void Method()
    {
        Console.WriteLine("Method from custom exception");
    }
}