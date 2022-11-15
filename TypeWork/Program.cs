// HomeWOrk from 15.11.2022



// 1. Пользователь вводит границы интервала из которого программа загадывает число.
// Написать программу про поиску данного числа. Пользователь пишет число в консоль,
// программа отвечает. 

{
    System.Console.WriteLine("введите границы числового диапазона");
    System.Console.WriteLine("введите минимальный порог:");
    int minValue = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("введите максимально допустимое значение");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int random = new Random().Next(minValue, maxValue);
    System.Console.WriteLine("попробуй угадать число,которое я загадал");
    int tryGuess=Convert.ToInt32(Console.ReadLine());
    if(random==tryGuess)
    {
        System.Console.WriteLine("верно,как ты это сделал?");
    }
    else if(tryGuess<=random+10 && tryGuess>=random-10)
    {
        System.Console.WriteLine($"ты был близок {random}");
    }
    else
    {
        System.Console.WriteLine($"не угадал {random}");
    }




}