﻿using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1;
            number1 = 5;
            int number2 = 13;
            string opr = "+";

            System.Console.WriteLine(Switch(opr: opr, number1: number1, number2: number2));
            // System.Console.WriteLine(MethodSum(number1, number2));
            // System.Console.WriteLine(MethodDeference(number1, number2));
            // System.Console.WriteLine(MethodMultiplication(number1, number2));
            // System.Console.WriteLine(MethodDivision(number1, number2));
        }

        static int MethodSum(int number, int number1) => number + number1;
        static int MethodDeference(int number, int number1) => number - number1;
        static int MethodMultiplication(int number, int number1) => number * number1;
        static int MethodDivision(int number, int number1) => number / number1;

        static string Switch(int number1, int number2, string opr) => opr switch
        {
            "+" => MethodSum(number1, number2).ToString(),
            "-" => MethodDeference(number1, number2).ToString(),
            "*" => MethodMultiplication(number1, number2).ToString(),
            "/" => MethodDivision(number1, number2).ToString(),
            _ => string.Format("No resultations {0}", opr)
        };
    }
}

#region Task2
// 2. Написать метод по рассчету средней скорости на участке и выводе сообщения
// превысил водитель скорость или нет. Метод должен принимать во сколько
// водитель въехал в участок контроля скорости и время во сколько выехал из
// участка, в виде HH:MM:SS, длинну учатска контроля скорости и среднюю
// допустимую скорость участка
// В задаче использовать необязательные парметры, локальные методы

#endregion

#region  Task3
// 3. Написать метод увеличению размера массива и заполнения его значениями
// В задаче использовать необязательные парметры, локальные методы.


#endregion


#region  Task4
// 4. Написать метод по расчету корней квадратного уравнения с использованием
// локального метода 
static void Korni()
{
    System.Console.WriteLine(" у нас есть квадратное уравнение вида ax^2+bx+с=0");
}



#endregion