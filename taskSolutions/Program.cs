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
//     string den= denNedeli switch
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

//4. Есть строка в 3 символа. Написать проверку если число, вывести true, в
// противном случае false (Char.IsDigit(str2, position))

// {
//     Console.WriteLine("введите любых три символа");
//     var nabor = "0.456";
//     var tip=nabor.GetType();
//     if(tip=System.Int32)
//     //System.Console.WriteLine(nabor.GetType());


// }
// 5. Пользователь вводит число с клавиатуры. Нужно вывести на экран сколько в этом
// числе цифр, а также положительное оно или отрицательное. Например, "Число " +
// num + " однозначное положительное". (Length) string characters = "abc\u0000def";Console.WriteLine(characters.Length); // Displays 7
// {
//     Console.WriteLine("Введите любое число");
//     double chisloUsera = Convert.ToDouble(Console.ReadLine());
//     string result = $"{chisloUsera} - ";
//     if (chisloUsera / 10 < 1)
//     {
//        result +="однозначное ";
//     }
//     else if (chisloUsera / 10 >= 1 && chisloUsera / 10 < 10)
//     {
//         result +="двухзначное ";
//     }
//     else
//     {
//         result +="трехзначное ";
//     }
//     if (chisloUsera > 0)
//     {
//         result += "положительное";
//     }
//     else
//     {
//         result += "отрицательное";
//     }
//     Console.WriteLine($"{result}");

// }

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

// 2 способ
 Console.WriteLine("Введите порядковый номер месяца в году(1-12):");
int nomerMesiaca=Convert.ToInt32(Console.ReadLine());
string poraGoda= nomerMesiaca switch
{
    0 or >12 or <0 =>"попробуй еще раз",
    1=> "зима",
    2=> "зима",
    3=>"весна",
    4=>"весна",
    5=>"весна",
    6=>"лето",
    7=>"лето",
    8=>"лето",
    9=>"осень",
    10=>"осень",
    11=>"осень",
    12=>"зима"

};
Console.WriteLine(poraGoda);
