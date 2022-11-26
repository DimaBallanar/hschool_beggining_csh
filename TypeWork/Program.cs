// // HomeWOrk from 15.11.2022



// // 1. Пользователь вводит границы интервала из которого программа загадывает число.
// // Написать программу про поиску данного числа. Пользователь пишет число в консоль,
// // программа отвечает. 

// {
//     System.Console.WriteLine("введите границы числового диапазона");
//     System.Console.WriteLine("введите минимальный порог:");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("введите максимально допустимое значение");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
//     int random = new Random().Next(minValue, maxValue);
//     System.Console.WriteLine(random);
//     do
//     {
//         System.Console.WriteLine("попробуй угадать число,которое я загадал");
//         int tryGuess = Convert.ToInt32(Console.ReadLine());
//         if (tryGuess >= minValue && tryGuess <= maxValue && !)
//         {
//             if (random == tryGuess)
//             {
//                 System.Console.WriteLine("верно,как ты это сделал?");
//                 break;
//             }
//             else if (tryGuess <= random + 10 && tryGuess >= random - 10)
//             {
//                 System.Console.WriteLine($"ты был близок");
//             }
//             else
//             {
//                 System.Console.WriteLine($"очень холодно {random}");
//             }

//         }
//         else
//         {
//             System.Console.WriteLine("вы ввели число за даипазоном");
//         }
//     }
//     while (random >= minValue && random <= maxValue);
// }




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
//             // liter += textRandom[i] is int place ? place : default;
//             // int.TryParse(textRandom[i].ToString,out int kolvo)
//             // if(textRandom[i].GetType()==Int32)
//             if (int.TryParse(textRandom[i].ToString(), out int par))
//             {
//                 number += 1;
//             }
//             else if (char.IsLetter(textRandom[i]))
//             {
//                 liter += 1;
//             }
//             else if (Convert.ToString(textRandom[i]) == " ")
//             {
//                 probel += 1;
//             }
//             else
//             {
//                 symbol += 1;
//             }

//         }
//         System.Console.WriteLine(number);
//         System.Console.WriteLine(liter);
//         System.Console.WriteLine(probel);
//         System.Console.WriteLine(symbol);
//     }
//     else
//     {
//         System.Console.WriteLine("empty");
//     }


// }

// 3. Пользователь вводит символ. Записать все позиции данного данного символа в строке в
// массив и вывести через символ, который кажет пользователь.

// {
//     System.Console.WriteLine("введите текст");
//     string? uxerText = Console.ReadLine();
//     // string uxerText = "dfdf eqe qeq eqeq qsdb";
//     System.Console.WriteLine("введите символ для поиска");
//     string? userFind = Console.ReadLine();
//     // string userFind = 'e'.ToString();
//     if (!string.IsNullOrEmpty(uxerText) && !string.IsNullOrEmpty(userFind))
//     {
//         int p = 0;
//         string[] result = new string[uxerText.Length];
//         foreach (char us in uxerText)
//         {
//             if (userFind == us.ToString())
//             {
//                 result[p] += us;
//                 p++;
//             }
//             else
//             {
//                 result[p] += 0;
//                 p++;
//             }
//         }
//         System.Console.WriteLine(string.Join(',', result));
//     }
//     else
//     { System.Console.WriteLine("null"); }
// }




// // 4. Пользователь вводит число N, которое является индексом последнего элемента ряда
// //Фиббоначи. Вывести весь этот ряд записанный в массив.


// {
//     System.Console.WriteLine("введите число N");
//     int N = Convert.ToInt32(Console.ReadLine());
//     int f = 0;
//     int s = 1;
//     int[] result = new int[N];
//     for (int i = 2; i < N; i++)
//     {
//         result[i - 2] = f;
//         result[i - 1] = s;
//         result[i] = f + s;
//         f = s;
//         s = result[i];
//     }

//     System.Console.WriteLine(string.Join(' ', result));

// }



// 5. У пользователя есть строка, удалить из неё все числа и символы ‘.’, ‘-’, ‘,’ , ‘*’ и тд. Заменить
// пробелы символом ‘/’. Если пользователь ввел символ вопрос ‘?’ он может быть только один
// и после него пробелы должны заменены на ‘=‘, все большие буквы заменить на маленькую и
// перед ней поставить ‘-’, но результирующая строка не может начинаться с ‘-’
// ПриветМир, я Пишу код*который не ВсегдаХороший)Но я?Учусь и у Меня?Все получится
// привет-мир/я/-пишу/кодкоторый/не/-всегда-хороший-но/я?-учусь=и=у=-менявсе=получится

{
    System.Console.WriteLine("введите строку");
    string? userText = Console.ReadLine();
    string result = "";
    if (!string.IsNullOrEmpty(userText))
    {
        foreach (char t in userText)
        {
            if (char.IsDigit(t))
            {
                result += "";
            }
            else if (t == ' ')
            {
                result += '/';
            }
            else
            {
                result += t;
            }
        }
        System.Console.WriteLine(result);
    }
    else
    {
        System.Console.WriteLine("null or empty");
    }
}