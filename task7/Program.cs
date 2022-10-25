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

//7