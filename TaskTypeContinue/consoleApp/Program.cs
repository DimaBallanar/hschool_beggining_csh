// //1. Вы вводите значение с клавиатуры. Если значение равно 0, то вывести ‘Ноль’, 
// //если < 0, то вывести ‘Отрицательное’, если > 0, то вывести ‘Положительное’

// {
//     Console.WriteLine("введите любое число: ");
//     string? chisloStasa = Console.ReadLine();
//     int ciferka = Convert.ToInt32(chisloStasa);
//     if (ciferka == 0)
//     {
//         Console.WriteLine("Ноль");
//     }
//     else if (ciferka < 0)
//     {
//         Console.WriteLine("Отрицательное");
//     }
//     else
//     {
//         Console.WriteLine("Положительное");
//     }
// }

// // второй способ написания через тернарный оператор
// {
//     Console.WriteLine("введите любое число: ");
//     int chisloStasa = Convert.ToInt32(Console.ReadLine());
//     string ciferka = chisloStasa == 0 ? "Ноль" : chisloStasa < 0 ? "Отрицательное" : "Положительное";
//     System.Console.WriteLine(ciferka);
// }

// //2 Вы вводите значение с клавиатуры. Если значение четное, то вывести true, в противном случае false

// {
//     Console.WriteLine("введите число с клавиатуры: ");
//     string? chisloStasa = Console.ReadLine();
//     int ciferka = Convert.ToInt32(chisloStasa);
//     if (ciferka % 2 == 0)
//     {
//         Console.WriteLine("TRUE");
//     }
//     else
//     {
//         Console.WriteLine("FALSE");
//     }
// }

// // решение через тернарный оператор

// {
//     Console.WriteLine("введите любое число: ");
//     int chisloStasa = Convert.ToInt32(Console.ReadLine());
//     string ciferka = chisloStasa % 2 == 0 ? "TRUE" : "FALSE";
//     System.Console.WriteLine(ciferka);
// }

// //3)Пользователь вводит с клавиатуры число. Найдите корень введенного числа 
// //(если же результат – число с плавающей точкой, то округлить до 2 знаков после запятой).

// {

//     Console.WriteLine("введите число с клавиатуры: ");
//     string? chisloStasa = Console.ReadLine();
//     double ciferka = Convert.ToInt32(chisloStasa);
//     if (ciferka <= 0)
//     {
//         Console.WriteLine("ERROR");
//     }
//     else
//     {
//         double koren = Math.Sqrt(ciferka) * 100;
//         int krygliKoren = (int)koren;
//         double vivod = Convert.ToDouble(krygliKoren) / 100;
//         Console.WriteLine(vivod);
//     }
// }


// //4)Пользователь вводит с клавиатуры 2 числа: a и b. Проверьте, что a делится без 
// //остатка на b. Если это так - выведите 'Делится' и результат деления, иначе 
// //выведите 'Делится с остатком' и остаток от деления

// {
//     Console.WriteLine("введите число с клавиатуры a: ");
//     string? chisloStasa = Console.ReadLine();
//     double pervoeChisleco = Convert.ToDouble(chisloStasa);
//     Console.WriteLine("введите число с клавиатуры b: ");
//     string? chisloDimicha = Console.ReadLine();
//     double vtoroeChisleco = Convert.ToDouble(chisloDimicha);
//     if (pervoeChisleco % vtoroeChisleco == 0)
//     {
//         int rezultatDelenia = Convert.ToInt32(pervoeChisleco / vtoroeChisleco);
//         Console.WriteLine($"ДЕЛИТСЯ {rezultatDelenia}");
//     }
//     else
//     {
//         double rezultatDrobnogoDelenia = pervoeChisleco / vtoroeChisleco;
//         Console.WriteLine($"ДЕЛИТСЯ с остатком {rezultatDrobnogoDelenia}");
//     }
// }


// // 5.Пользователь вводит с клавиатуры число. Найдите корень введенного числа 
// //(если же результат – число с плавающей точкой, то округлить до целых)

// {
//     Console.WriteLine("введите число с клавиатуры: ");
//     string? chisloStasa = Console.ReadLine();
//     double ciferka = Convert.ToInt32(chisloStasa);
//     if (ciferka <= 0)
//     {
//         Console.WriteLine("ERROR");
//     }
//     else
//     {
//         double koren = Math.Sqrt(ciferka);
//         int krygliKoren = (int)koren;
//         Console.WriteLine(krygliKoren);
//     }
// }

// //6.Даны три числа a, b, c. Напишите программу, которая находит корни квадратного уравнения 
// //ax^2 + bx + c = 0
// //Если уравнение имеет два корня, то следует вывести их в порядке возрастания.

// {
//     Console.WriteLine("введите любое число a: ");
//     double chisloA = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("введите любое число b: ");
//     double chisloB = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("введите любое число c: ");
//     double chisloC = Convert.ToInt32(Console.ReadLine());
//     Double Discriminant = chisloB * chisloB - 4 * chisloA * chisloC;
//     if (Discriminant > 0)
//     {
//         double koren1 = (-chisloB - Math.Sqrt(Discriminant)) / (2 * chisloA);
//         double koren2 = (-chisloB + Math.Sqrt(Discriminant)) / (2 * chisloA);
//         double maxKoren = Math.Max(koren1, koren2);
//         double minKoren = Math.Min(koren1, koren2);
//         Console.WriteLine($"{minKoren} , {maxKoren}");
//     }
//     else if (Discriminant == 0)
//     {
//         double koren1 = (-chisloB - Math.Sqrt(Discriminant)) / (2 * chisloA);
//         Console.WriteLine(koren1);
//     }
//     else
//     {
//         Console.WriteLine("Нет корней");
//     }
// }

// //7. Пользователь вводит число от 1 до 9999 (сумму выдачи в банкомате). Необходимо 
// // вывести на экран словами введенную сумму и в конце написать название валюты 
// // с правильным окончанием. Например: 7431 – семь тысяч четыреста тридцать один 
// // доллар, 2149 – две тысячи сто сорок девять долларов, 15 – пятнадцать долларов, 3 – три доллара.
// // string result = $"{number} - "
// {
//     Console.WriteLine("ВВедите число от 1 до 9999");
//     int money = Convert.ToInt32(Console.ReadLine());
//     string result = $"{money} - ";
//     // int edinica = money / 1; 
//     // int desiatka = money / 10; 
//     // int sotka = money / 100; 
//     int tisiacha = money / 1000;
//     if (tisiacha == 1)
//     {
//         result += "одна тысяча ";
//     }
//     else if (tisiacha == 2)
//     {
//         result += "две тысячи ";
//     }
//     else if (tisiacha == 3)
//     {
//         result += "три тысячи ";
//     }
//     else if (tisiacha == 4)
//     {
//         result += "четыре тысячи ";
//     }
//     else if (tisiacha == 5)
//     {
//         result += "пять тысяч ";
//     }
//     else if (tisiacha == 6)
//     {
//         result += "шесть тысяч ";
//     }
//     else if (tisiacha == 7)
//     {
//         result += "семь тысяч ";
//     }
//     else if (tisiacha == 8)
//     {
//         result += "восемь тысяч ";
//     }
//     else if (tisiacha == 9)
//     {
//         result += "девять тысяч ";
//     }
//     int ostatokTisiachi = money - tisiacha * 1000;
//     int beremSotki = ostatokTisiachi / 100;
//     if (beremSotki == 0)
//     {
//         result += " ";
//     }
//     if (beremSotki == 1)
//     {
//         result += "сто ";
//     }
//     else if (beremSotki == 2)
//     {
//         result += "двести ";
//     }
//     else if (beremSotki == 3)
//     {
//         result += "триста ";
//     }
//     else if (beremSotki == 4)
//     {
//         result += "четыреста ";
//     }
//     else if (beremSotki == 5)
//     {
//         result += "пятьсот ";
//     }
//     else if (beremSotki == 6)
//     {
//         result += "шестьсот ";
//     }
//     else if (beremSotki == 7)
//     {
//         result += "семьсот ";
//     }
//     else if (beremSotki == 8)
//     {
//         result += "восемьсот ";
//     }
//     else if (beremSotki == 9)
//     {
//         result += "девятьсот ";
//     }

//     int ostatokSotki = ostatokTisiachi - beremSotki * 100;
//     int beremDesiatki = ostatokSotki / 10;
//     if (beremDesiatki == 0)
//     {
//         result += " ";
//     }
//     if (beremDesiatki == 1)
//     {
//         int chisloOstatka = ostatokSotki - beremDesiatki * 10;
//         if (chisloOstatka < 0)
//             result += "десять ";
//     }
//     else if (beremDesiatki == 2)
//     {
//         result += "двадцать ";
//     }
//     else if (beremDesiatki == 3)
//     {
//         result += "тридцать ";
//     }
//     else if (beremDesiatki == 4)
//     {
//         result += "сорок ";
//     }
//     else if (beremDesiatki == 5)
//     {
//         result += "пятьдесят ";
//     }
//     else if (beremDesiatki == 6)
//     {
//         result += "шестьдесят ";
//     }
//     else if (beremDesiatki == 7)
//     {
//         result += "семьдесят ";
//     }
//     else if (beremDesiatki == 8)
//     {
//         result += "восемьдесят ";
//     }
//     else if (beremDesiatki == 9)
//     {
//         result += "девяносто ";
//     }

//     int ostatokDesiatki = ostatokSotki - beremDesiatki * 10;
//     int beremEdinici = ostatokDesiatki;
//     if (beremEdinici == 0)
//     {
//         result += "долларов";
//     }
//     if (beremEdinici == 1 && beremDesiatki > 1 || beremEdinici == 1 && beremDesiatki < 1)
//     {
//         result += "один доллар";
//     }
//     else if (beremEdinici == 1 && beremDesiatki == 1)
//     {
//         result += "одиннадцать долларов";
//     }
//     else if (beremEdinici == 2 && beremDesiatki > 1 || beremEdinici == 1 && beremDesiatki < 1)
//     {
//         result += "два доллара";
//     }
//     else if (beremEdinici == 2 && beremDesiatki == 1)
//     {
//         result += "двеннадцать долларов";
//     }
//     else if (beremEdinici == 3 && beremDesiatki > 1 || beremEdinici == 1 && beremDesiatki < 1)
//     {
//         result += "три доллара";
//     }
//     else if (beremEdinici == 3 && beremDesiatki == 1)
//     {
//         result += "триннадцать долларов";
//     }
//     else if (beremEdinici == 4 && beremDesiatki > 1 || beremEdinici == 1 && beremDesiatki < 1)
//     {
//         result += "четыре доллара";
//     }
//     else if (beremEdinici == 4 && beremDesiatki == 1)
//     {
//         result += "четырнадцать долларов";
//     }
//     else if (beremEdinici == 5 && beremDesiatki > 1 || beremEdinici == 1 && beremDesiatki < 1)
//     {
//         result += "пять долларов";
//     }
//     else if (beremEdinici == 5 && beremDesiatki == 1)
//     {
//         result += "пятнадцать долларов";
//     }
//     else if (beremEdinici == 6 && beremDesiatki > 1 || beremEdinici == 1 && beremDesiatki < 1)
//     {
//         result += "шесть долларов";
//     }
//     else if (beremEdinici == 6 && beremDesiatki == 1)
//     {
//         result += "шестнадцать долларов";
//     }
//     else if (beremEdinici == 7 && beremDesiatki > 1 || beremEdinici == 1 && beremDesiatki < 1)
//     {
//         result += "семь долларов";
//     }
//     else if (beremEdinici == 7 && beremDesiatki == 1)
//     {
//         result += "семнадцать долларов";
//     }
//     else if (beremEdinici == 8 && beremDesiatki > 1 || beremEdinici == 1 && beremDesiatki < 1)
//     {
//         result += "восемь долларов";
//     }
//     else if (beremEdinici == 8 && beremDesiatki == 1)
//     {
//         result += "восемнадцать долларов";
//     }
//     else if (beremEdinici == 9 && beremDesiatki > 1 || beremEdinici == 1 && beremDesiatki < 1)
//     {
//         result += "девять долларов";
//     }
//     else if (beremEdinici == 9 && beremDesiatki == 1)
//     {
//         result += "девятнадцать долларов";
//     }

//     Console.WriteLine($"{result}");
// }


// //8.Пользователь вводит порядковый номер пальца руки. Необходимо показать его название на экран
// {

//     Console.WriteLine("Выберите руку : левая или правая");
//     var ruka = Console.ReadLine();
//     Console.WriteLine("ВВедите порядковый номер пальца руки слева-направо");
//     int palec = Convert.ToInt32(Console.ReadLine());
//     if (ruka == "правая")
//     {
//         if (palec == 1)
//         {
//             Console.WriteLine("БОЛЬШОЙ");
//         }
//         else if (palec == 2)
//         {
//             Console.WriteLine("Указательный");
//         }
//         else if (palec == 3)
//         {
//             Console.WriteLine("Средний");
//         }
//         else if (palec == 4)
//         {
//             Console.WriteLine("Безымянный");
//         }
//         else
//         {
//             Console.WriteLine("Мезинец");
//         }
//     }

//     else
//     {
//         if (palec == 1)
//         {
//             Console.WriteLine("мезинец");
//         }
//         else if (palec == 2)
//         {
//             Console.WriteLine("безымянный");
//         }
//         else if (palec == 3)
//         {
//             Console.WriteLine("Средний");
//         }
//         else if (palec == 4)
//         {
//             Console.WriteLine("указательный");
//         }
//         else
//         {
//             Console.WriteLine("большой");
//         }
//     }
// }

// //9.Необходимо написать программу, которая проверяет пользователя на знание таблицы умножения. Пользователь сам вводит два целых однозначных числа. 
// //Программа задаёт вопрос: результат умножения первого числа на второе. Пользователь должен ввести ответ и увидеть на экране правильно он 
// //ответил или нет. Если нет – показать еще и правильный результат.

// {
//     Console.WriteLine("давай проверим на сколько хорошо ты знаешь таблицу умножения");
//     Thread.Sleep(2000);
//     Console.WriteLine("введи первое число :");
//     int pervoeChislo = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("введи второе число :");
//     int vtoroeChislo = Convert.ToInt32(Console.ReadLine());
//     int Reshenie = pervoeChislo * vtoroeChislo;
//     Console.WriteLine("какой результат умножения первого числа на второе?");
//     int otvetUsera = Convert.ToInt32(Console.ReadLine());
//     if (Reshenie == otvetUsera)
//     {
//         String boxer = Convert.ToString("все верно");
//         Console.WriteLine(boxer);
//     }
//     else
//     {
//         Console.WriteLine($"не верно! правильный ответ: {Reshenie}");
//     }
// }


//10.Пользователь вводит два числа, если хотя бы одно число равно 0 то необходимо 
//получить битовую инверсию числа не равного 0, если первое число больше 20, 
//необходимо найти остаток от делания большего на меньшее, если второе меньше 
//0 найти модуль целой часть от деления первого числа на второе, если первое и 
//второе числа чётные найти логическое битовое И для двух чисел, в противном 
//случае логическое битовое ИЛИ. 
//Для полученного результата произвести битовый сдвиг который укажет пользователь, если сдвиг четный, то сдвиг вправо, 
//если нечетный влево. Полученный результат вывести на экран

{

    Console.WriteLine("Введите первое число");
    int pervoeChislo = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите первое число");
    int vtoroeChislo = Convert.ToInt32(Console.ReadLine());
    if (pervoeChislo == 0 | vtoroeChislo == 0)
    {
        if (pervoeChislo == 0)
        {
            int inversiaVtorogoChisla = ~vtoroeChislo;
            Console.WriteLine("введите битовый сдвиг");
            int sdvig = Convert.ToInt32(Console.ReadLine());
            if (sdvig % 2 == 0)
            {
                int rezult = inversiaVtorogoChisla >> sdvig;
                Console.WriteLine(rezult);
            }
            else
            {
                int rezult = inversiaVtorogoChisla << sdvig;
                Console.WriteLine(rezult);
            }
        }
        else
        {
            int inversiapervogoChisla = ~pervoeChislo;
            Console.WriteLine("введите битовый сдвиг");
            int sdvig = Convert.ToInt32(Console.ReadLine());
            if (sdvig % 2 == 0)
            {
                int rezult = inversiapervogoChisla >> sdvig;
                Console.WriteLine(rezult);
            }
            else
            {
                int rezult = inversiapervogoChisla << sdvig;
                Console.WriteLine(rezult);
            }
        }
    }
    else if (pervoeChislo > 20)
    {
        int ostatokDelenia = Math.Max(pervoeChislo, vtoroeChislo) % Math.Min(pervoeChislo, vtoroeChislo);
        int p = Convert.ToInt32(pervoeChislo % 2);
        int v = Convert.ToInt32(vtoroeChislo % 2);
        if (p == 0 & v == 0)
        {
            char bitovoeI = Convert.ToChar(p & v);
            Console.WriteLine("введите битовый сдвиг");
            int sdvig = Convert.ToInt32(Console.ReadLine());
            if (sdvig % 2 == 0)
            {
                int rezult = bitovoeI >> sdvig;
                Console.WriteLine(rezult);
            }
            else
            {
                int rezult = bitovoeI << sdvig;
                Console.WriteLine(rezult);
            }
        }
        else
        {
            char bitovoeIli = Convert.ToChar(p ^ v);
            Console.WriteLine("введите битовый сдвиг");
            int sdvig = Convert.ToInt32(Console.ReadLine());
            if (sdvig % 2 == 0)
            {
                int rezult = bitovoeIli >> sdvig;
                Console.WriteLine(rezult);
            }
            else
            {
                int rezult = bitovoeIli << sdvig;
                Console.WriteLine(rezult);
            }
        }
    }
    else if (vtoroeChislo < 0)
    {
        int modulCelayaChast = Math.Abs(pervoeChislo / vtoroeChislo);
        Console.WriteLine("введите битовый сдвиг");
        int sdvig = Convert.ToInt32(Console.ReadLine());
        if (sdvig % 2 == 0)
        {
            int rezult = modulCelayaChast >> sdvig;
            Console.WriteLine(rezult);
        }
        else
        {
            int rezult = modulCelayaChast << sdvig;
            Console.WriteLine(rezult);
        }
    }
}




