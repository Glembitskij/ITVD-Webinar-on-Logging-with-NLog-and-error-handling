// Обробка винятків
// Мова C# надає розробникам можливості для обробки помилок які виникають під час виконання,
// для цього в C# призначена конструкція try...catch...finally.

int x = 10;
int y = 20;
int res;

//res = x / (y - 20);

try
{
    x = x / (y - 20);
}
catch (Exception exception)
{
    Console.WriteLine("Обработка винятку");
    Console.WriteLine(exception.Message);
    exception.HelpLink = "https://itvdn.com/ua";
    Console.WriteLine(exception.HelpLink);
}