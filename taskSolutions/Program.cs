// // 1. Найти максимальное число из 2 введенных (2 способа)

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
// {
//     Console.WriteLine("Введите любое число");
//     string? chisloUsera = Console.ReadLine();
//     // string? result = $"{chisloUsera} - ";
//     int length= chisloUsera?.Length ?? default;
//     Console.Write($"{chisloUsera} в нем {length} цифр ");
//     // if(int.TryParse(chisloUsera, out int perevod ))
//     // if (perevod / 10 < 1)
//     // {
//     //    result +="однозначное ";
//     // }
//     // else if (perevod / 10 >= 1 && perevod / 10 < 10)
//     // {
//     //     result +="двухзначное ";
//     // }
//     // else
//     // {
//     //     result +="трехзначное ";
//     // }
//     if (chisloUsera > 0)
//     {
//         Console.Write( "положительное");
//     }
//     else
//     {
//         Console.Write( "отрицательное");
//     }


// }

// // 6. Найти квадратный корень числа. Если же число без плавающей точки, то просто вывести его. В противном случае необходимо округлить число до целых.
// Добавить проверку на ввод только чисел
// {
//     System.Console.WriteLine("введите число");
//     string? userNumber = Console.ReadLine();
//     if (int.TryParse(userNumber, out int result))
//     {
//         double chislo = Math.Sqrt(result);
//         string stringResult = Convert.ToString(chislo);
//         if (int.TryParse(stringResult, out int userNum))
//         {
//             System.Console.WriteLine(userNum);
//         }
//         else
//         {
//             System.Console.WriteLine($"{Convert.ToInt32(chislo)}");
//         }
//     }
//     else
//     {
//         System.Console.WriteLine("вы ввели не число");
//     }

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
//      string? userNumber = Console.ReadLine();
//     if (int.TryParse(userNumber, out int santimetri))
//     {

//     Console.WriteLine($" в {santimetri} см  {santimetri/100}м");
//     }
//     else
//     {
//         System.Console.WriteLine("вы ввели не число");
//     }
// }

// 12.Напишите программу, в которой рассчитывается сумма и произведение цифр
// положительного трёхзначного числа 123 -> Сумма цифр = 6 Произведение цифр = 6
// {
//     System.Console.WriteLine("введите трехзначное число");
//     string? userVvod = Console.ReadLine();
//     if ((int.TryParse(userVvod, out int gotovo)) && gotovo > 99 && gotovo < 1000)
//     {
//         int sotkiNumber = gotovo / 100;
//         int desyatkiNumber = (gotovo - sotkiNumber * 100) / 10;
//         int ediniciNumber = (gotovo - sotkiNumber * 100 - desyatkiNumber * 10);
//         System.Console.WriteLine($" сумма чисел {sotkiNumber + desyatkiNumber + ediniciNumber} ,  произведение {sotkiNumber * desyatkiNumber * ediniciNumber}");

//     }
//     else
//     {
//         System.Console.WriteLine("вы ввели значения не по условиям задачи");
//     }
// }


// 13. Пользователь вводит четырехзначное число. Напишите код, который будет
// выявлять является ли каждое составляющее числа четным либо нечетным.
// Добавить проверку на ввод только чисел
// 1234 -> 1 – неч 2 – чет 3 – неч 4 - чет
// {
//     System.Console.WriteLine("введите четырехзначное число");
//     string? userInput = Console.ReadLine();
//     if (int.TryParse(userInput, out int number0))
//     {
//         int number1 = number0 / 1000;
//             int number2 = (number0 - number1 * 1000) / 100;
//            int number3 = (number0 - number1 * 1000 - number2 * 100) / 10;
//                int number4 = number0 - number1 * 1000 - number2 * 100 - number3 * 10;
//                string chetnoe1 = number1 > 0 && number1 % 2 == 0 ? $"{number1}-четное " : $"{number1} не четное ";
//         string chetnoe2 = number2 > 0 && number2 % 2 == 0 ? $"{number2}-четное " : $"{number2} не четное ";
//         string chetnoe3 = number3 > 0 && number3 % 2 == 0 ? $"{number3}-четное " : $"{number3} не четное ";
//         string chetnoe4 = number4 > 0 && number4 % 2 == 0 ? $"{number4}-четное " : $"{number4} не четное ";
//         System.Console.WriteLine($"{chetnoe1},{chetnoe2},{chetnoe3},{chetnoe4}");

//     }
//     else
//     {
//         System.Console.WriteLine("вы ввели не число");
//     }
// }




// 14. Пользователь вводит 2 числа от 0 до 10. Сложите переменные так, чтобы в
// результате получилось выражение: “I’m хх". Проверки на ввод только чисел.
// Проверки на ввод чисел до 10. Если первое число – 0, то опустить его
// {
//     Console.WriteLine("введите первое число");
//     string? numberFirst = Console.ReadLine();
//     Console.WriteLine("введите первое число");
//     string? numberSecond = Console.ReadLine();
//     if (int.TryParse(numberFirst, out int number1) && int.TryParse(numberSecond, out int number2))
//     {
//         if (number1 >= 0 && number1 <= 10 && number2 >= 0 && number2 <= 10)
//         {
//             if (number1 == 0)
//             {
//                 Console.WriteLine($"I'm {number2}");
//             }
//             else
//             {
//                 Console.WriteLine($"I'm {number1}{number2}");
//             }
//         }
//         else
//         {
//             Console.WriteLine("вы ввели число не от 0 до 10");
//         }
//     }
//     else
//     {
//         Console.WriteLine("вы ввели не числа");
//     }

// }
//15.Пользователь вводит строку. Необходимо сделать проверку, что это не число и вывести длину строки
// {
//     Console.WriteLine("Введите строку ");
//     string? text = Console.ReadLine();
//     if (!int.TryParse(text, out _)) // "_" игнорируем объявление переменной
//     {
//         string result = !string.IsNullOrEmpty(text)? $"Длинна строки {text.Length}" : "пустота";
//         Console.WriteLine(result);
//         // if (!string.IsNullOrEmpty(text)) //(text != null) "" // string.IsNullOrEmpty(text) првоеряет на пустое значение если пустое то true
//         // {
//         //     text =$"Длинна строки {text.Length}";
// System.Console.WriteLine(text);
//         // }
//         //  else
//         // {
//         //     text = "пустота";
// System.Console.WriteLine(text);
//         // }
//     }
//     else
//     {
//         Console.WriteLine("ввели число");
//     }
// }


// 16.Пользователь вводит строку. Вывести первый символ строки (индексы)

// System.Console.WriteLine("введите строку");
// string? stroka = Console.ReadLine();
// Console.WriteLine(stroka?[0]);
//

// 17.Пользователь вводит строку. Необходимо сделать проверку, что это не число и
// вывести текущую строку в большом регистре
// {
//  System.Console.WriteLine("введите строку");
//  string? stroka = Console.ReadLine();
//  if(!string.IsNullOrEmpty(stroka))
//  {
//  if(int.TryParse(stroka, out _))
//  {
//     System.Console.WriteLine("вы ввели число");

//  }
//  else
//  {
//     System.Console.WriteLine(stroka.ToUpper());
//  }
//  }
// }


// 18. Пользователь вводит строку. Необходимо повторить ее трижды

{
     System.Console.WriteLine("введите строку");
string? stroka = Console.ReadLine();
System.Console.WriteLine(string.Concat(stroka,stroka,stroka));

}
// //19.
// string? inMessage = Console.ReadLine();
// int number;
// if (int.TryParse(inMessage, out number))
// {
//     if (number % 2 == 0)
//     {
//         Console.WriteLine ("четное");
//     }
//     else {Console.WriteLine ("нечетное");}
// }
// else 
// {
//     if(inMessage=="hschool")
//     {Console.WriteLine (true);}
//     else {Console.WriteLine (false);}
// }





