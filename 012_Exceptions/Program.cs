// Блок finally

try
{
    throw new Exception();
}
catch (Exception)
{
    //finally - не спрацює якщо не закінчится робота блоку catch
    while (true)
        Console.WriteLine("Catch");
}
finally
{
    // finally - не спрацює!
    while (true)
        Console.WriteLine("Finally");
}
