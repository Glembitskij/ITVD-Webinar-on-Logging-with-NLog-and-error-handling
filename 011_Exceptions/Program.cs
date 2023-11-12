// Рекурсивний виклик методу та блок finally

try
{
    RecursiveMethod(0);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);

}
finally
{
    // finally - в жанному випадку не спрацює 
    Console.WriteLine(" StackOverflowException.");
}

// Метод імітує переповнення стеку
static void RecursiveMethod(int counter)
{
    // Рекурсивний виклик методу
    RecursiveMethod(counter + 1);
}