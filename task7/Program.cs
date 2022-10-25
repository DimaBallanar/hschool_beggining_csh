// // zada4i 25.10.2022
// // 1. Объявить оперменные и поменять в Hих значения три раза (string, int, bool, double)

// {
//     string stringType1 = "45grr";
//     Console.WriteLine(stringType1);
//     stringType1 = stringType1 + "Weak";
//     Console.WriteLine(stringType1);
//     stringType1 = stringType1 + "Wea";
//     Console.WriteLine(stringType1);
//     stringType1 = stringType1 + "rotor";
//     Console.WriteLine(stringType1);
// }
// {
//     int intType1 = 865;
//     Console.WriteLine(intType1);
//     intType1 = intType1 - 10;
//     Console.WriteLine(intType1);
//     intType1 = intType1 / 2;
//     Console.WriteLine(intType1);
//     intType1 = intType1 * 9;
//     Console.WriteLine(intType1);
// }
// {
//     bool boolType1 = true;
//     Console.WriteLine(boolType1);
//     boolType1 = !boolType1;
//     Console.WriteLine(boolType1);
//     boolType1 = !boolType1 && !boolType1;
//     Console.WriteLine(boolType1);
//     boolType1 = !boolType1 || !boolType1;
//     Console.WriteLine(boolType1);
// }
// {
//     double doubleType1 = 865;
//     Console.WriteLine(doubleType1);
//     doubleType1 = doubleType1 - 10;
//     Console.WriteLine(doubleType1);
//     doubleType1 = ++doubleType1;
//     Console.WriteLine(doubleType1);
//     doubleType1 = doubleType1 % 2;
//     Console.WriteLine(doubleType1);
// }
// //2.2. Произвести все все комбинации неявного преобразования (byte, int, long, float, double, decemel)

// {
//     byte byteType = 3;
//     int intType = byteType;
//     long longType = intType;
//     float floatType = longType;
//     double doubleType = floatType;
//     decimal decimaType = (decimal)doubleType;  //нельзя неявно преобразовать

// }

// //3.Произвести все все комбинации явного преобразования (byte, int, long, float, double, decemel)
// {
//     decimal decimaValue = 2;
//     double doubleValue = Convert.ToDouble(decimaValue);
//     float floatValue = Convert.ToSingle(doubleValue);
//     long longValue = Convert.ToInt64(floatValue);
//     int intValue = Convert.ToInt32(longValue);
//     byte byteValue = Convert.ToByte(intValue);

// }

// // 4. Ввести два числа, произвести арифметические действия над числами и записать результат в первое число (+, -, /, *, %)
// {
//     Console.WriteLine("ВВедите число а: ");
//     int numberA=Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("ВВедите число b: ");
//     int numberB=Convert.ToInt32(Console.ReadLine());
//     numberA=numberA+numberB;
//     Console.WriteLine(numberA );
//     numberA=numberA-numberB;
//     Console.WriteLine(numberA );
//     numberA=numberA/numberB;
//     Console.WriteLine(numberA );
//     numberA=numberA*numberB;
//     Console.WriteLine(numberA );
//     numberA=numberA%numberB;
//     Console.WriteLine(numberA );

// }

// //5  Ввести число и увеличить его на 1 всеми доступными способами
// {
//     Console.WriteLine("VVedite chislo:");
//     int number5=Convert.ToInt32(Console.ReadLine());
//     number5=number5+1;
//     Console.WriteLine(number5);
//     number5+=1;
//     Console.WriteLine(number5);
//     ++number5;
//     Console.WriteLine(number5);
//     number5++;
//     Console.WriteLine(number5); // вопрос -как вывести результат этого постфиксного инкремента,ВСПОМНИТЬ,ПОчитать
//     // number5=number5+0;
//     // Console.WriteLine(number5);
// }

// //6. Ввести строку, если строка число найти остаток от деления на 5, в противном случае вывести сообщение, что введено не число

// {
//     Console.WriteLine("VVedite stroky");
//     string? stroka =Console.ReadLine();
//     if(int.TryParse(stroka, out int number))
//     {
//         int ostatokDelenia=number%5;
//         Console.WriteLine(ostatokDelenia);
//     }
// else{
//     Console.WriteLine("vvedeno ne chislo");
// }
// }

// //7. Ввести две строки, если строки числа вывести их сумму, в противном случае вывести сообщение какие строки не являются числом
// {
//     Console.WriteLine("Введите первую строку");
//     string? strokaOdin = Console.ReadLine();
//     Console.WriteLine("Введите вторую строку");
//     string? strokaDva = Console.ReadLine();
//     if (int.TryParse(strokaOdin, out int strokaOdinChisla) && int.TryParse(strokaDva, out int strokaDvaChisla))
//     {
//         Console.WriteLine(strokaOdinChisla + strokaDvaChisla);
//     }
//     else if (int.TryParse(strokaOdin, out int chisloOdin))
//     {
//         Console.WriteLine("первая строка число,вторая не число");
//     }
//     else if (int.TryParse(strokaDva, out int chisloDva))
//     {
//         Console.WriteLine("вторая строка число,первая не число");
//     }
//     else
//     {
//         Console.WriteLine("первая и вторая строки не числа");
//     }
// }

// //8. Ввести два числа, если 1 число больше 2, то произвести деление 1 на 2, если 2 больше 1 вывести разность между 2 и 1,
// //  в противном случае вернуть 0.0 и результат увеличить на 10 (if-else, тернаный оператор)

// {
//     Console.WriteLine("Введите первое число:");
//     int numberA=Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите второе число:");
//     int numberB=Convert.ToInt32(Console.ReadLine());
//     int answerA = numberA>2 ? numberA/numberB : numberA=numberA+10;
//     int answerB= numberB>1 ? numberB-numberA : numberB=numberB+10;
//     Console.WriteLine($"{answerA} {answerB}");

// }
// 9.9. Ввести две строки, если две строки числа то ввести арифметический оператор, 
// b в зависисмоти от арфметического оператора произвести то действие в проитивных случаях произвести вывод сообщений. 
// Сделать проверку на null оператора (if-else, switch, сокращенный switch)

// IF-ELSE
{
    Console.WriteLine("Введите первую строку");
    string? strokaOdin = Console.ReadLine();
    Console.WriteLine("Введите вторую строку");
    string? strokaDva = Console.ReadLine();
    if (int.TryParse(strokaOdin, out int strokaA) && int.TryParse(strokaDva, out int strokaB))
    {
        Console.WriteLine("Введите операцию");
        string? operacia = Console.ReadLine();
        if (operacia?.Equals("+") ?? false) // ?? проверка оператора на null
        {
            Console.WriteLine(strokaA + strokaB);
        }
        else if (operacia?.Equals("-") ?? false)
        {
            Console.WriteLine(strokaA - strokaB);
        }
        else if (operacia?.Equals("*") ?? false)
        {
            Console.WriteLine(strokaA * strokaB);
        }
        else if(operacia?.Equals("/")??false)
        {
            Console.WriteLine(strokaA /strokaB);
        }
        else if(operacia?.Equals("%")??false)
        {
            Console.WriteLine(strokaA %strokaB);
        }
    }
    else
    {
        Console.WriteLine($"{strokaOdin} {strokaDva}");
    }
}

//SWITCH

{
    Console.WriteLine("Введите первую строку");
    string? strokaOdin = Console.ReadLine();
    Console.WriteLine("Введите вторую строку");
    string? strokaDva = Console.ReadLine();
    switch(int.TryParse(strokaOdin, out int strokaA) && int.TryParse(strokaDva, out int strokaB))
    {
        Console.WriteLine("Введите операцию");
        string? operacia = Console.ReadLine();
        case operacia?.Equals("+") ?? false :
        System.Console.WriteLine($" {strokaA}+{strokaB}");
        break;
    }
}