// Обробка винятків
// Мова C# надає розробникам можливості для обробки помилок які виникають під час виконання,
// для цього в C# призначена конструкція try...catch...finally.

int x = 10;
int[] array = new[] { 1, 10, 20} ;
int indexs = int.Parse(Console.ReadLine());
int res;

//res = x / (y - 20);

try
{
    x = x / (array[indexs] - 20);
}
// Важливий порядок блоків catch !
catch (DivideByZeroException exception)
{
    Console.WriteLine("Обработка винятку ділення на нуль!");
    // В цьому випадку хочемо завершити виконання програми
    return;
    
}
catch(IndexOutOfRangeException exception)
{
    Console.WriteLine("Обработка винятку ділення на нуль!");
    // Вважаємо помилку не критичною, тому ігноруємо її
}
catch (Exception exception)
{
    Console.WriteLine("Обработка решти винятків!");
    // Виводимо на консоль попередження та продовжуємо роботу 
}

Console.WriteLine("Continuation of work");