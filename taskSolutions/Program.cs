﻿// // 1. Найти максимальное число из 2 введенных (2 способа)

// //1 способ
// {
// Console.WriteLine("Введите первое число:");
// int numberPerviy = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int numberVtoroy = Convert.ToInt32(Console.ReadLine());
// if(numberPerviy>numberVtoroy)
// {
//     Console.WriteLine(numberPerviy);
// }
// else
// {
//     Console.WriteLine(numberVtoroy);
// }
// }

// //2 способ
// {
// Console.WriteLine("Введите первое число:");
// int numberPerviy = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int numberVtoroy = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Math.Max(numberPerviy,numberVtoroy));
// }

// //2. Выявить является ли введенное число четным
// {
//     Console.WriteLine("Введите число:");
//     int chisloZadachiDva=Convert.ToInt32(Console.ReadLine());
//     int result = chisloZadachiDva%2;
//     string otvet = result==0? "четное" : "не четное";
//     Console.WriteLine(otvet);
// }

//3.Пользователь вводит число от 1 до 7, соответствующее дню недели. Необходимо
// вывести день для введенного числа

// {
//     Console.WriteLine("Введите число от 1 до 7 :");
//     int denNedeli=Convert.ToInt32(Console.ReadLine());
//     string? den= denNedeli switch
//     {
//         0 or >7 or <0 => "я просил с 1 до 7",   // я бы тут добавил ссылку/возврат к 42 строке,чтобы юзер ввел заново число
//         1 => "понедельник",
//         2 => "вторник",
//         3 => "среда",
//         4 => "четверг",
//         5 => "пятница",
//         6 => "суббота",
//         7 => "воскресенье"
//     };
//     System.Console.WriteLine(den);
// }

// 4. Есть строка в 3 символа. Написать проверку если число, вывести true, в
// противном случае false (Char.IsDigit(str2, position))

// {
//     Console.WriteLine("введите любых три символа");
//     string? nabor = Console.ReadLine();
//     if(int.TryParse(nabor, out int number)
//     var tip=nabor.GetType();
//     if(tip=System.Int32)
//     //System.Console.WriteLine(nabor.GetType());


// }
// 5. Пользователь вводит число с клавиатуры. Нужно вывести на экран сколько в этом
// числе цифр, а также положительное оно или отрицательное. Например, "Число " +
// num + " однозначное положительное". (Length) string characters = "abc\u0000def";Console.WriteLine(characters.Length); // Displays 7
{
    Console.WriteLine("Введите любое число");
    string? chisloUsera = Console.ReadLine();
    // string? result = $"{chisloUsera} - ";
    int length= chisloUsera?.Length ?? default;
    Console.Write($"{chisloUsera} в нем {length} цифр ");
    // if(int.TryParse(chisloUsera, out int perevod ))
    // if (perevod / 10 < 1)
    // {
    //    result +="однозначное ";
    // }
    // else if (perevod / 10 >= 1 && perevod / 10 < 10)
    // {
    //     result +="двухзначное ";
    // }
    // else
    // {
    //     result +="трехзначное ";
    // }
    if (chisloUsera > 0)
    {
        Console.Write( "положительное");
    }
    else
    {
        Console.Write( "отрицательное");
    }
    

}

// // 6. Найти квадратный корень числа. Если же число без плавающей точки, то просто вывести его. В противном случае необходимо округлить число до целых.
// Добавить проверку на ввод только чисел
// {

// }

// 7. Два автомобиля едут друг к другу с постоянными скоростями V1 и V2 км/ч.
// Определите, через какое время автомобили встретятся, если расстояние между
// ними равно S км. Добавить проверку на ввод только чисел

// {
//     Console.WriteLine("введите скорость первого автомобиля,км/ч:");  // ???Дописать проверку на ввод только цифр???
//     double vPervogoAvto=Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("введите скорость первого автомобиля,км/ч:");
//     double vVtorogoAvto=Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("введите расстояние между ними,км ");
//     double rasstoianieS=Convert.ToInt32(Console.ReadLine());
//     double vremia=rasstoianieS/(vPervogoAvto+vVtorogoAvto);
//     Console.WriteLine($"они встретятся через {vremia} часа");
// }

// 8. Пользователь вводит номер месяц. Необходимо вывести пору года по номеру
// месяца (2 способа)

// 1 способ
// Console.WriteLine("Введите порядковый номер месяца в году(1-12):");
// int nomerMesiaca=Convert.ToInt32(Console.ReadLine());
// if(nomerMesiaca<=2 || nomerMesiaca==12)
// {
//     Console.WriteLine("пора года - зима");
// }
// else if(nomerMesiaca>2 && nomerMesiaca<6)
// {
//     Console.WriteLine("пора года - весна");
// }
// else if(nomerMesiaca>6 && nomerMesiaca<9)
// {
//     Console.WriteLine("пора года - лето");
// }
// else
// {
//     Console.WriteLine("пора года - осень");
// }

// // 2 способ
//  Console.WriteLine("Введите порядковый номер месяца в году(1-12):");
// int nomerMesiaca=Convert.ToInt32(Console.ReadLine());
// string poraGoda= nomerMesiaca switch
// {
//     0 or >12 or <0 =>"попробуй еще раз",
//     1=> "зима",
//     2=> "зима",
//     3=>"весна",
//     4=>"весна",
//     5=>"весна",
//     6=>"лето",
//     7=>"лето",
//     8=>"лето",
//     9=>"осень",
//     10=>"осень",
//     11=>"осень",
//     12=>"зима"

// };
// Console.WriteLine(poraGoda);

// 9.Пользователь вводит число: 1, 2, 3 или 4. Если это значение ‘2', то вывести в
// консоль 'зима близко', ‘3' – зима, ‘4' – всё' . Решите задачу через switch-case. 

// {
//     Console.WriteLine("Введи 1,2,3 или 4");
//     int cifraClienta = Convert.ToInt32(Console.ReadLine());
//     switch (cifraClienta)
//     {
//         case 1:
//             // System.Console.WriteLine("");
//             // break;
//         case 2:
//             System.Console.WriteLine("Зима близко");
//             break;
//         case 3:
//             System.Console.WriteLine("Зима");
//             break;
//         case 4:
//             System.Console.WriteLine("Всё");
//             break;
//     }
    

// }

// //10. Пользователь вводит одно число. Необходимо вывести обратное ему (число
// // является обратным при 1/x). Если при этом введённое с клавиатуры число – ноль,
// // то вывести «Обратного числа не существует». 

// {
//     Console.WriteLine("Введите число:");
// double chisloUsera=Convert.ToInt32(Console.ReadLine());
// if(chisloUsera==0)
// {
//     Console.WriteLine("Обратного числа не существует");
// }
// else
// {
//     double obratnoeChislo=Convert.ToDouble(1/chisloUsera);
//     Console.WriteLine(obratnoeChislo);
// }
// }

// //11.Напишите программу, которая находит полное число метров по заданному числу
// // сантиметров. Добавить проверку на ввод только чисел

// {
//     Console.WriteLine("введите количество сантиметров");  //надо сделать проверку на ввод чисел
//     int santimetri=Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine($" в {santimetri} см  {santimetri/100}м");
// }

// 12.
// {
//     Console.WriteLine("Задача номер 15.");
//     Console.WriteLine("Введите строку ");
//     string? text = Console.ReadLine();
//     if (!int.TryParse(text, out _)) // "_" игнорируем объявление переменной
//     {
//         string result = !string.IsNullOrEmpty(text)? $"Длинна строки {text.Length}" : "пустота";
//         Console.WriteLine(result);
//         // if (!string.IsNullOrEmpty(text)) //(text != null) "" // string.IsNullOrEmpty(text) првоеряет на пустое значение если пустое то true
//         // {
//         //     text =$"Длинна строки {text.Length}";
//         // }
//         //  else
//         // {
//         //     text = "пустота";
//         // }
//     }
//     else
//     {
//         Console.WriteLine("ввели число");
//     }
// }