// // // 1 1. Выведите столбец чисел от 1 до 50. for, while
// {
//     System.Console.WriteLine("for");
//     for (int i = 1; i <= 50; i++)
//     {
//         System.Console.WriteLine(i);
//     }
//     System.Console.WriteLine("while");
//     {
//         int i = 1;
//         while (i <= 50)
//         {
//             System.Console.WriteLine(i++);
//         }
//     }
// }

// // 2. [1, 2, 3, 4, 5]. Выведите каждый элемент массива 3 любыми циклами
// {
//     System.Console.WriteLine("for");
//     int[] massiv = new int[] { 1, 2, 3, 4, 5 };
//     for (int i = 0; i < massiv.Length; i++)
//     {
//         System.Console.WriteLine(massiv[i]);
//     }

//     System.Console.WriteLine("while");
//     int index = 0;
//     while (index < 5)
//     {
//         System.Console.WriteLine(massiv[index]);
//         index++;
//     }
//     System.Console.WriteLine("foreach");
//     foreach (int count in massiv)
//     {
//         System.Console.WriteLine(count);
//     }
// }
// // 3. Дан массив с элементами [2, 3, 4, 5]. С помощью 3 циклов найдите произведение
// // элементов этого массива.
// {
//     System.Console.WriteLine("for");
//     int[] massiv = new int[] { 2, 3, 4, 5 };
//     int umnFor = 1;
//     for (int i = 0; i < massiv.Length; i++)
//     {
//         umnFor = umnFor * massiv[i];
//     }
//     System.Console.WriteLine(umnFor);

//     System.Console.WriteLine("while");
//     int index = 0;
//     int umnWhile = 1;
//     while (index < 4)
//     {
//         umnWhile = umnWhile * massiv[index];
//         index++;
//     }
//     System.Console.WriteLine(umnWhile);
//     System.Console.WriteLine("foreach");
//     int umnForeEach = 1;
//     foreach (int count in massiv)
//     {
//         umnForeEach = umnForeEach * massiv[count - 2];
//     }
//     System.Console.WriteLine(umnForeEach);
// }

// // 4. Выведите столбец чисел от 11 до 33 циклом while
// {
//     int i = 11;
//     while (i <= 33)
//     {
//         System.Console.WriteLine(i++);
//     }
// }
// // 5. Выведите столбец четных чисел в промежутке от 0 до 100 (for)

// for (int i = 2; i <= 100; i += 2)
// {
//     System.Console.WriteLine(i);
// }
// 6. С помощью цикла while найдите сумму чисел от 1 до 100.
// {
//     int i = 1;
//     int summa = 0;
//     while (i <= 100)
//     {
//         summa += i;
//         i++;
//     }
//     System.Console.WriteLine(summa);
// }
// 
// 7. Дан массив с элементами [1, 2, 3, 4, 5]. С помощью цикла for of найдите сумму
// элементов этого массива
// {
//     int[] macbook = new int[5] { 1, 2, 3, 4, 5 };
//     int sum = 0;
//     for (int i = 0; i < macbook.Length; i++)
//     {
//         sum += macbook[i];
//     }
//     System.Console.WriteLine(sum);
// }
//  2 способ с foreach=========================================================
// {
//     int[] iphone=new int[5]{1,2,3,4,5};
//     int summForeach=0;
//     foreach(int iphon in iphone)
//     {
//         summForeach+=iphon;
//     }
// System.Console.WriteLine(summForeach);
// }
// 

// 8. Дан массив 2, 5, 9, 15, 0, 4. Выведите все числа кратные 3 циклом foreach in

// {
//     int[] massiv8 = new int[] { 2, 5, 9, 15, 0, 4 };
//     foreach (int mass in massiv8)
//     {
//         if (mass % 3 == 0 & mass > 0)
//         {
//             System.Console.WriteLine(mass);
//         }
//     }
// }

// 9. Дан массив с элементами [1, 2, 2, 3, 4, 4, 3, 4, 5]. Выведите только уникальные
// значения массива -> [1, 5] (for)

// {
//     int[] massiv9 = new int[] { 1, 2, 2, 3, 4, 4, 3, 4, 5 };
//     int one = 0;
//     int two = 0;
//     int three = 0;
//     int four = 0;
//     int five = 0;
//     for (int i = 0; i < massiv9.Length; i++)
//     {
//         if (massiv9[i] == 1)
//         {
//             one += 1;
//         }
//         if (massiv9[i] == 2)
//         {
//             two += 1;
//         }
//         if (massiv9[i] == 3)
//         {
//             three += 1;
//         }
//         if (massiv9[i] == 4)
//         {
//             four += 1;
//         }
//         if (massiv9[i] == 5)
//         {
//             five += 1;
//         }
//     }
//     if (one == 1)
//     {
//         System.Console.WriteLine('1');
//     }
//     if (two == 1)
//     {
//         System.Console.WriteLine('2');
//     }
//     if (three == 1)
//     {
//         System.Console.WriteLine('3');
//     }
//     if (four == 1)
//     {
//         System.Console.WriteLine('4');
//     }
//     if (five == 1)
//     {
//         System.Console.WriteLine('5');
//     }

// }

// =================================================================   не потянул ,логика есть,реализация хромает
// 2 способ с .Count()
// {
//     int[] massiv9 = new int[] { 1, 2, 2, 3, 4, 4, 3, 4, 5 };
//     for (int i = 0; i < massiv9.Length; i++)
//     {
//         for (int k = i; k < massiv9.Length; k++)
//         {
//             int skok = 0;
//             int number = massiv9.Count(k, skok +=);
//         }
//         if (massiv9.Count() == 1)
//         {
//             System.Console.WriteLine(massiv9[i]);
//         }
//     }
// }

// // 10. Дан массив 2, 5, 9, 15, 0, 4. Выведите все числа кратные 5 циклом while

// {
//     int[] massiv10 = new int[] { 2, 5, 9, 15, 0, 4 };
//     int index = 0;
//     while (index < massiv10.Length)
//     {
//         if (massiv10[index] % 5 == 0 && massiv10[index] != 0)
//         {
//             System.Console.WriteLine(massiv10[index]);
//         }
//         index += 1;
//     }
// }


// 11. Дан массив с числами. Числа могут быть положительными и отрицательными.
// Найдите сумму всех положительных элементов массива циклом foreach in

// {
// System.Console.WriteLine(" введите длину массива");
// int massivLength = Convert.ToInt32(Console.ReadLine());
// int[] massiv = new int[massivLength];
// for (int i = 0; i < massivLength; i++)
// {
//     System.Console.WriteLine($"введите {i} элемент массива");
//     massiv[i] = Convert.ToInt32(Console.ReadLine());
//     if (string.IsNullOrEmpty(Convert.ToString(massiv[i])))     //не работает ,как хочу : при вводе пустого числа в массив-должно вбивать ноль
//     {
//         massiv[i] = 0;
//     }
// }
// int summMassiv = 0;
// foreach (int mass in massiv)
// {
//     if (mass > 0)
//     {
//         summMassiv += mass;
//     }
// }
// System.Console.WriteLine(summMassiv);
// }


// 12.Дан массив числами, например: [10, 20, 30, 50, 235, 3000]. 
// Выведите на экран только те числа из массива, которые начинаются на цифру 1, 2 или 5 -> 10, 20, 50, 235

// {
//     int[] loopMassiv = new int[] { 10, 20, 30, 50, 235, 3000 };
//     foreach (int loop in loopMassiv)
//     {
//         string lop = Convert.ToString(loop);
//         if (lop.StartsWith('1') || lop.StartsWith('2') || lop.StartsWith('5'))
//         {
//             System.Console.Write($"{lop} ");
//         }
//     }
// }

// 13.Дан массив с элементами 1, 2, 3, 4, 5, 6, 7, 8, 9. С помощью цикла for создайте строку '-1-2-3-4-5-6-7-8-9-‘

// {
//     int[] massNumber = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//     string textLine = "-";
//     for (int i = 0; i < massNumber.Length; i++)
//     {
//         textLine += massNumber[i];
//         textLine += "-";
//     }
//     System.Console.WriteLine(textLine);
// }

// 14.Дано число 7, найдите все числа кратные 7 до 100

// {
//     int number = 1;
//     string result = "";
//     while (number <= 100)
//     {
//         if (number % 7 == 0)
//         {
//             result += $"{number} ";
//         }
//         number++;
//     }
//     System.Console.Write(result);
// }


// 15.Дано предложение и количество раз которое его надо повторить. Напишите программу, 
// которая повторяет данное предложение нужное количество раз.


// {
//     System.Console.WriteLine("введите любое предложение");
//     string? userText = Convert.ToString(Console.ReadLine());
//     System.Console.WriteLine("сколько раз это предложение надо повторить?");
//     int repeat = Convert.ToInt32(Console.ReadLine());
//     for (int i = 1; i <= repeat; i++)
//     {
//         System.Console.WriteLine(userText);
//     }
// }


// 16.Пользователь вводит число, явдяющееся количеством элементов будущего массива и 
// выбирает тип данных массива. Напишите код заполнения массива выбранным типом данных. 

// {
//     System.Console.WriteLine("введите количество элементов будущего массива");
//     int massivLength = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("выберите тип данных массива: текст или число");
//     string? userType = Console.ReadLine();
//     if (!string.IsNullOrEmpty(userType))
//     {
//         if (userType == "текст")
//         {
//             string[] text = new string[massivLength];
//             for (int i = 0; i < massivLength; i++)
//             {
//                 System.Console.WriteLine($"введите {i} элемент массива");
//                 text[i] = Console.ReadLine();
//             }
//             System.Console.WriteLine(String.Join(',', text));
//         }
//         if (userType == "число")
//         {
//             double[] numeration = new double[massivLength];
//             for (int i = 0; i < massivLength; i++)
//             {
//                 System.Console.WriteLine($"введите {i} элемент массива");
//                 numeration[i] = Convert.ToDouble(Console.ReadLine());
//             }
//             System.Console.WriteLine(String.Join(',', numeration));
//         }
//     }
//     else
//     {
//         System.Console.WriteLine("null");
//     }
// }


// 17.Пользователь вводит число, явдяющееся количеством элементов будущего массива.
//  Напишите код заполнения массива. Записать в массив только числа.
// {
//     System.Console.WriteLine("введите число-размер массива");
//     int massivPower = Convert.ToInt32(Console.ReadLine());
//     string[] massiv = new string[massivPower];
//     for (int i = 0; i < massivPower; i++)
//     {
//         System.Console.WriteLine($"введите {i} элемент массива");
//         string? number = Console.ReadLine();
//         if (int.TryParse(number, out _))
//         {
//             massiv[i] = number;
//         }
//         else
//         {
//             massiv[i] = "0";
//         }
//     }
//     System.Console.WriteLine(string.Join(',', massiv));
// }

// 18.Пользователь вводит многозначное число. Необходимо вставить двоеточие между двумя нечетными числами.
//  Работать с числом как с массивом. Использовать for 55639217 -> 5:563:921:7.

{
    System.Console.WriteLine("введите любое число");
    string? userNumber = Convert.ToString(Console.ReadLine());
    if (!string.IsNullOrEmpty(userNumber))
    {
        char[] massiv = userNumber.ToCharArray();
        string result = "";
        for (int i = 0; i < massiv.Length - 1; i++)
        {
            if (massiv[i] % 2 != 0 && massiv[i + 1] % 2 != 0)
            {
                result += massiv[i];
                result += ":";
            }

            else
            {
                result += massiv[i];
            }

        }
        result += massiv[massiv.Length - 1];
        System.Console.WriteLine(result);
    }
    else
    {
        System.Console.WriteLine("null");
    }
}




