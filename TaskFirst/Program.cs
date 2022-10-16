// See https://aka.ms/new-console-template for more information

Console.Write("Please, write your name: ");
var textFromReadLine = Console.ReadLine();
Console.WriteLine($"Hello, {textFromReadLine}");
Console.Write("HOW old are you? ");
int age = Convert.ToInt32(Console.ReadLine());
if(age < 30)
{
    Console.WriteLine($"{age} ?-самое время для изучения");
}
else
{
    Console.WriteLine($"{age} ? знаешь,никогда не поздно начинать");
}
Console.Write("как думаешь,через сколько месяцев ты освоишь язык C#?: ");
int month = Convert.ToInt32(Console.ReadLine());
if (month < 6)
{
    Console.WriteLine($"{month} ? а ты оптимист)");
}
else
{
    Console.WriteLine($"{month} ? я думаю у тебя получится быстрее)");
}
// дано Console.WriteLine("Hello, " "World!"); лишние двойные кавычки
Console.WriteLine("Hello, World!");
// dano Console.WriteLine('Hello, World!"); в начале одиночная 
Console.WriteLine("Hello, World!");
// dano Console.WriteLine(Hello, World!); нет кавычек
Console.WriteLine("Hello, World!");
// dano Console.WriteLine("Hello, {name}!); в конце кавычку
Console.WriteLine("Hello, {name}!");
Console.ReadKey(true);