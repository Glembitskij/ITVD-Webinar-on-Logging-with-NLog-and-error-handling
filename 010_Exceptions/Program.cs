// InnerException є властивістю класу винятка (Exception),
// яка представляє собою вкладений виняток. Коли виняток виникає всередині іншого винятка,
// властивість InnerException дозволяє отримати доступ до вкладеного винятка.

ClassCustomException customException = new ClassCustomException();

try
{
    customException.DoSomeWork();
}
catch (Exception exception)
{
    Console.WriteLine("Exception caught: {0}", exception.Message);
    Console.WriteLine("Inner Exception : {0}", exception.InnerException?.Message);
}

public class ClassCustomException
{
    public void WriteLog(string logMessage)
    {
        WriteLogException exp = new WriteLogException("Внутрішне виключення");
        throw exp;
    }

    public void DoSomeWork()
    {
        try
        {
            WriteLog("Do work");
        }
        catch (WriteLogException exception)
        {
            throw new Exception("Зовнішне виключення!", exception);
        }
    }
}

public class WriteLogException : Exception
{
    public WriteLogException() { }
    public WriteLogException(string message) : base(message) { }
}
