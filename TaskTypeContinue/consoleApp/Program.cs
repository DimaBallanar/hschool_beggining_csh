//1. Вы вводите значение с клавиатуры. Если значение равно 0, то вывести ‘Ноль’, 
//если < 0, то вывести ‘Отрицательное’, если > 0, то вывести ‘Положительное’

{
    Console.WriteLine("введите любое число: ");
    string? chisloStasa = Console.ReadLine();
    int ciferka = Convert.ToInt32(chisloStasa);
    if (ciferka == 0)
    {
        Console.WriteLine("Ноль");
    }
    else if (ciferka < 0)
    {
        Console.WriteLine("Отрицательное");
    }
    else
    {
        Console.WriteLine("Положительное");
    }
}

// второй способ написания через тернарный оператор
{
    Console.WriteLine("введите любое число: ");
    int chisloStasa = Convert.ToInt32(Console.ReadLine());
    string ciferka = chisloStasa == 0 ? "Ноль" : chisloStasa < 0 ? "Отрицательное" : "Положительное";
    System.Console.WriteLine(ciferka);
}

//2 Вы вводите значение с клавиатуры. Если значение четное, то вывести true, в противном случае false

{
    Console.WriteLine("введите число с клавиатуры: ");
    string? chisloStasa = Console.ReadLine();
    int ciferka = Convert.ToInt32(chisloStasa);
    if (ciferka % 2 == 0)
    {
        Console.WriteLine("TRUE");
    }
    else
    {
        Console.WriteLine("FALSE");
    }
}

// решение через тернарный оператор

{
    Console.WriteLine("введите любое число: ");
    int chisloStasa = Convert.ToInt32(Console.ReadLine());
    string ciferka = chisloStasa % 2 == 0 ? "TRUE" : "FALSE";
    System.Console.WriteLine(ciferka);
}

//3)Пользователь вводит с клавиатуры число. Найдите корень введенного числа 
//(если же результат – число с плавающей точкой, то округлить до 2 знаков после запятой).

{

    Console.WriteLine("введите число с клавиатуры: ");
    string? chisloStasa = Console.ReadLine();
    double ciferka = Convert.ToInt32(chisloStasa);
    if (ciferka <= 0)
    {
        Console.WriteLine("ERROR");
    }
    else
    {
        double koren = Math.Sqrt(ciferka) * 100;
        int krygliKoren = (int)koren;
        double vivod = Convert.ToDouble(krygliKoren) / 100;
        Console.WriteLine(vivod);
    }
}


//4)Пользователь вводит с клавиатуры 2 числа: a и b. Проверьте, что a делится без 
//остатка на b. Если это так - выведите 'Делится' и результат деления, иначе 
//выведите 'Делится с остатком' и остаток от деления

{
    Console.WriteLine("введите число с клавиатуры a: ");
    string? chisloStasa = Console.ReadLine();
    double pervoeChisleco = Convert.ToDouble(chisloStasa);
    Console.WriteLine("введите число с клавиатуры b: ");
    string? chisloDimicha = Console.ReadLine();
    double vtoroeChisleco = Convert.ToDouble(chisloDimicha);
    if (pervoeChisleco % vtoroeChisleco == 0)
    {
        int rezultatDelenia = Convert.ToInt32(pervoeChisleco / vtoroeChisleco);
        Console.WriteLine($"ДЕЛИТСЯ {rezultatDelenia}");
    }
    else
    {
        double rezultatDrobnogoDelenia = pervoeChisleco / vtoroeChisleco;
        Console.WriteLine($"ДЕЛИТСЯ с остатком {rezultatDrobnogoDelenia}");
    }
}


// 5.Пользователь вводит с клавиатуры число. Найдите корень введенного числа 
//(если же результат – число с плавающей точкой, то округлить до целых)

{
    Console.WriteLine("введите число с клавиатуры: ");
    string? chisloStasa = Console.ReadLine();
    double ciferka = Convert.ToInt32(chisloStasa);
    if (ciferka <= 0)
    {
        Console.WriteLine("ERROR");
    }
    else
    {
        double koren = Math.Sqrt(ciferka);
        int krygliKoren = (int)koren;
        Console.WriteLine(krygliKoren);
    }
}

//6.Даны три числа a, b, c. Напишите программу, которая находит корни квадратного уравнения 
//ax^2 + bx + c = 0
//Если уравнение имеет два корня, то следует вывести их в порядке возрастания.

{
    Console.WriteLine("введите любое число a: ");
    int chisloA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите любое число b: ");
    int chisloB = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите любое число c: ");
   int chisloC = Convert.ToInt32(Console.ReadLine());
    Double Discriminant = chisloB*chisloB - 4*chisloA*chisloC;
    if(Discriminant>0)
    {
        int koren1 = Convert.ToInt32((-chisloB-Math.Sqrt(Discriminant))/(2*chisloA));
        int koren2 = Convert.ToInt32((-chisloB+Math.Sqrt(Discriminant))/(2*chisloA));
        double maxKoren = Math.Max(koren1,koren2);
        double minKoren = Math.Min(koren1,koren2);
        Console.WriteLine($"{minKoren} , {maxKoren}");
    }
    else if(Discriminant==0)
    {
       int koren1 = Convert.ToInt32(-chisloB-Math.Sqrt(Discriminant))/(2*chisloA); 
       Console.WriteLine(koren1);
    }
    else
    {
        Console.WriteLine("Нет корней");
    }
}

//7. Пользователь вводит число от 1 до 9999 (сумму выдачи в банкомате). Необходимо 
// вывести на экран словами введенную сумму и в конце написать название валюты 
// с правильным окончанием. Например: 7431 – семь тысяч четыреста тридцать один 
// доллар, 2149 – две тысячи сто сорок девять долларов, 15 – пятнадцать долларов, 3 – три доллара.

{
    Console.WriteLine("ВВедите число от 1 до 9999");
    int denegki = Convert.ToInt32(Console.ReadLine());

}


//8.Пользователь вводит порядковый номер пальца руки. Необходимо показать его название на экран
{
    
    Console.WriteLine("Выберите руку : левая или правая");
    var ruka = Console.ReadLine();
    Console.WriteLine("ВВедите порядковый номер пальца руки слева-направо");
    int palec = Convert.ToInt32(Console.ReadLine());
    if(ruka=="правая")
    {
    if(palec==1)
    {
        Console.WriteLine("БОЛЬШОЙ");
    }
    else if(palec==2)
    {
        Console.WriteLine("Указательный");
    }
     else if(palec==3)
    {
        Console.WriteLine("Средний");
    }
 else if(palec==4)
    {
        Console.WriteLine("Безымянный");
    }
     else
    {
        Console.WriteLine("Мезинец");
    }
}

else
{
    if(palec==1)
    {
        Console.WriteLine("мезинец");
    }
    else if(palec==2)
    {
        Console.WriteLine("безымянный");
    }
     else if(palec==3)
    {
        Console.WriteLine("Средний");
    }
 else if(palec==4)
    {
        Console.WriteLine("указательный");
    }
     else
    {
        Console.WriteLine("большой");
    }
}
}

//