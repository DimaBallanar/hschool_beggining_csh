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
//(если же результат – число с плавающей точкой, то округлить то целых)

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
