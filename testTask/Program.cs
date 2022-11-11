// // // пользователь вводит два числа, и вводит оператор для них
// {

//     System.Console.WriteLine("введите первое число");
//     int number1 = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("введите второе число");
//     int number2 = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("введите операцию");
//     string? operation = Console.ReadLine();
//     switch (operation)
//     {
//         case "*":
//             System.Console.WriteLine(number1 * number2);
//             break;
//         case "+":
//             System.Console.WriteLine(number1 + number2);
//             break;
//         case "%":
//             System.Console.WriteLine(number1 % number2);
//             break;
//         case "/" when number2 != 0:
//             System.Console.WriteLine(number1 / number2);
//             break;
//         case "-":
//             System.Console.WriteLine(number1 - number2);
//             break;
//         default:
//             System.Console.WriteLine("ошибка ввода");
//             break;
//     }
// }
// {
//     System.Console.WriteLine("введите первое число");
//     int number1 = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("введите второе число");
//     int number2 = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("введите операцию");
//     string? operation = Console.ReadLine();
//     string result = operation switch
//     {
//         "*" => $"number1 * number2",
//         "-" => $"number1 * number2",
//         "+" => $"number1 * number2",
//         "/" => $"number1 * number2",
//         "%" => $"number1 * number2",
//         "^" => $"{Math.Pow(number1, number2)}",
//         _ => $"ошибка",
//     };
//     System.Console.WriteLine(result);
// }
// {
//     // object[] items = new object[6] { 48, -43, -41, -19, 95, 43 };
//     // int difference = 0;
//     // for (int i = 0; i < items.Length; i++)
//     // {
//     //     difference -= items[i] is int number ? number : default;
//     // }

//     // string? consoleText = Console.ReadLine();
//     // if (int.TryParse(consoleText, out int number) && number > 0)
//     // {
//     //     int result = 1;
//     //     for (int i = 0; i <= number; i++)
//     //     {
//     //         result *= i;
//     //     }
//     //     Console.WriteLine(result);
//     // }

//     // else
//     // {
//     //     Console.WriteLine("Вы ввели не натуральное число");
//     // }
// }

// // =======================random
// {
//     int number = new Random().Next(55, 777);
//     int result = 0;
//     for (int i = 1; i <= number; i++)
//     {
//         if (i == 451)
//         {
//             //Выход из цикла если i имеет значение 451
//             break;
//         }
//         else if (i % 3 == 0)
//         {
//             //Переходим на новую итерацию цикла i++
//             continue;
//         }

//         if (i % 4 == 0)
//         {
//             result += i / 4;
//         }
//         else if (i % 10 == 0)
//         {
//             result += i - 1;
//         }
//         else
//         {
//             result += i;
//         }
//     }
//     Console.WriteLine(result);
// }

// {
//     System.Console.WriteLine("введите любое число");
//     string? userNumber = Convert.ToString(Console.ReadLine());
//     if (!string.IsNullOrEmpty(userNumber))
//     {
//         char[] massiv = userNumber.ToCharArray();
//         string result = "";
//         for (int i = 0; i < massiv.Length - 1; i++)
//         {
//             if (massiv[i] % 2 != 0 && massiv[i + 1] % 2 != 0)
//             {
//                 result += string.Concat($"{massiv[i]}:");
//                 // result += ":";
//             }

//             else
//             {
//                 result += massiv[i];
//             }

//         }
//         result += massiv[massiv.Length - 1];
//         System.Console.WriteLine(result);
//     }
//     else
//     {
//         System.Console.WriteLine("null");
//     }

// }

// // // если число кратно 2 делим на 2 .  в противном случае добавляем 10-----------------------------------------------
// {
//     int[] numbers = { 1231, 41234, 312, 345, 344, 1312, 5, 324, 13, 131, 4, 5, 6, 7, 8, 898 };
//     System.Console.WriteLine(string.Join(",", numbers));
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         if (numbers[i] % 2 == 0)
//         {
//             numbers[i] /= 2;
//         }
//         else
//         {
//             numbers[i] += 10;
//         }
//     }
//     System.Console.WriteLine(string.Join(" , ", numbers));
//     int index = 0;
//     while (index < numbers.Length)
//     {
//         numbers[index] = numbers[index] % 2 == 0 ? numbers[index] / 2 : numbers[index] + 10;
//         index++;
//     }
//     System.Console.WriteLine(string.Join(" , ", numbers));
// }

// // есть массив строк-сконкатенировать все строки с циклом 
// {
//     string[] userText = new string[] { "frrdad", "213", "1234", "1245", "1313" };
//     string result = "";
//     for (int i = 0; i < userText.Length; i++)
//     {
//         result += userText[i];
//     }
//     System.Console.WriteLine(result);
//     int index = 0;
//     string resultWhile = "";
//     while (index < userText.Length)
//     {
//         resultWhile += userText[index++];
//     }
//     System.Console.WriteLine(resultWhile);
// }

// // дан массив строк, между ними поставить http

// {

//     string[] massiv = new[] { "github.com", "HannaPleshko" };
//     string result = "";
//     for (int i = 0; i < massiv.Length; i++)

//     {
//         result += massiv[i];
//     }
//     System.Console.WriteLine(string.Concat($"https://{result}"));
// }

// // у тебя есть массив чисел, ты с клавиатуры вводишь число, 
// // найти индекс первого вхождения этого числа в массиве, в противном случае вывести -1

// {
//     int[] massivNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 123, 1242, 2352, 234, 242, 52, 66, 56, 46, 7, 75, 85, 3, 5 };
//     System.Console.WriteLine("введите число");
//     int userNumber = Convert.ToInt32(Console.ReadLine());
//     int result = -1;
//     for (int i = 0; i < massivNumbers.Length; i++)
//     {
//         if (massivNumbers[i] == userNumber)
//         {
//             result = i;

//             break;
//         }
//     }
//     System.Console.WriteLine(result);


// }


System.Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
int c = 0;
if (number % 2 != 0 && number > 1)
{
    for (int i = 2; i <= 9; i++)
    {
        int b = i;
        if (number % b == 0)
        {
            c += 1;
        }
        System.Console.WriteLine($"{c}");
    }
    System.Console.WriteLine($"{c}");
}
if (c > 1)
{
    System.Console.WriteLine("не простое число");
}
else
{
    System.Console.WriteLine("простое");
}

