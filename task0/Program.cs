// See https://aka.ms/new-console-template for more information
Console.WriteLine("Привет, напиши своё имя: "); // прошу ввести свое имя
var textFromReadLine = Console.ReadLine(); // команда на считывание введенной инфы ,которая потом используется где пропишу textFromReadLine
Console.WriteLine($"Привет, {textFromReadLine}!");  // на основе введенный инфы пишется ответ
Thread.Sleep(1000);  //задается задержка между сообщениями в милисекундах(1000 милисекунд-1 секунда)
Console.WriteLine("У тебя есть лишних пару минут(есть= 1 нет времени= 2)?");
String otvet = Console.ReadLine();
Thread.Sleep(1500);
if (otvet == "да")
    {
        Console.WriteLine("ответь на пару вопросов");
    }
else
    {
        Console.WriteLine("не смею тебя задерживать");
        goto Found;                                     // отправляет выполнять задачу к слову found(пропуская всё);
    }
Thread.Sleep(2000);                                     
Console.WriteLine($"{textFromReadLine}, ты с какого города?");
var city = Console.ReadLine();
Thread.Sleep(1500);
Console.WriteLine($"{city} ? -это же в Казахстане");
var correctcountry = Console.ReadLine();
Thread.Sleep(1500);
Console.WriteLine($"Ой прости) точно,это же {correctcountry} , извини за путаницу");
Thread.Sleep(2000);
Console.WriteLine("я умею хорошо считать в уме. могу сложить,вычесть,умножить или разделить 2 любых числа");
Thread.Sleep(3000);
Console.WriteLine("проверь меня) назови какую операцию мне надо будет сделать: сложение,вычитание,умножение или деление");
string oper = Console.ReadLine();
Console.WriteLine("Задавай первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("а теперь второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
Thread.Sleep(1500);
Console.WriteLine("да это легко");
Thread.Sleep(1500);
if (oper == "сложение")
{
    int c = num1 + num2;
    Console.WriteLine("я считаю,что будет" + c);
}
else if (oper == "вычитание")
{
    int c = num1 - num2;
    Console.WriteLine("я считаю,что будет" + c);
}
else if (oper == "умножение")
{
    int c = num1 * num2;
    Console.WriteLine("я считаю,что будет" + c);
}
else
{
    double c = (num1 + .0) / num2;
    Console.WriteLine("я считаю,что будет " + c);
}
Found:
Thread.Sleep(2000);
Console.WriteLine("хорошего дня");
Console.ReadKey(true); // не дает закрыться консольному окну после завершения действий