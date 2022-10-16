// See https://aka.ms/new-console-template for more information
Console.WriteLine("Привет, напиши своё имя: "); // прошу ввести свое имя
var textFromReadLine = Console.ReadLine(); // команда на считывание введенной инфы ,которая потом используется где пропишу textFromReadLine
Console.WriteLine($"Привет, {textFromReadLine}!");  // на основе введенный инфы пишется ответ
Console.WriteLine("У тебя есть лишних пару минут(есть= da нет времени= net)?");
string otvet = Console.ReadLine();
if (otvet == "da")
    {
        Console.WriteLine("ответь на пару вопросов");
    }
else
    {
        Console.WriteLine("не смею тебя задерживать");
    }
