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
    int tryGuess;
    do
    {
        System.Console.WriteLine("попробуй угадать число,которое я загадал");
        tryGuess = Convert.ToInt32(Console.ReadLine());

        if (random == tryGuess)
        {
            System.Console.WriteLine("верно,как ты это сделал?");
            continue;
        }
        else if (tryGuess <= random + 10 && tryGuess >= random - 10)
        {
            System.Console.WriteLine($"ты был близок");
        }
        else
        {
            System.Console.WriteLine($"очень холодно {random}");
        }

    }
    while (random >= minValue && random <= maxValue);

}



// 2. Написать программу, которая подсчитывает количество в строке букв, пробелов, цифр и
// остальных символов.

// {
//     System.Console.WriteLine("введите набор текста");
//     string? textRandom = Console.ReadLine();
//     if (!string.IsNullOrEmpty(textRandom))
//     {
//         int liter = 0;
//         int probel = 0;
//         int number = 0;
//         int symbol = 0;
//         for (int i = 0; i < textRandom.Length; i++)
//         {
//             liter += textRandom[i] is int place? place : default;
//             int.TryParse(textRandom[i],out int kolvo)

//         }
//     }
//     else
//     {
//         System.Console.WriteLine("empty");
//     }


// }
