// Блок finally
try
{
    try
    {
        try
        {
            CustomException customException = new CustomException("Exception");
            throw customException;
        }
        catch (Exception exception)
        {
            Console.WriteLine("Catch 1: " + exception.Message);
            throw exception;
        }
        finally
        {
            Console.WriteLine("Finally 1:");
        }
    }
    catch (Exception exception)
    {
        Console.WriteLine("Catch 2: " + exception.Message);
        throw exception;
    }
    finally
    {
        Console.WriteLine("Finally 2:");
    }
}
catch (Exception exception)
{
    Console.WriteLine("Catch 3: " + exception.Message);
}
finally
{
    Console.WriteLine("Finally 3:");
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