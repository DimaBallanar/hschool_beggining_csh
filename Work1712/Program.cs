using System;

namespace TaskHard // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите число 1:");
            double.TryParse(Console.ReadLine(), out double number1);
            Console.Write("введите число 2:");
            double.TryParse(Console.ReadLine(), out double number2);

            double result = SummDouble(number1, number2);
            System.Console.WriteLine(result);

            Calculate calculate = new Calculate();
            result = calculate.Result;
            System.Console.WriteLine(result);
            System.Console.WriteLine(calculate.Summ(number2));
            System.Console.WriteLine(calculate.Defination(number2));
            System.Console.WriteLine(calculate.Division(number2));
            System.Console.WriteLine(calculate.Multiplication(number2));


        }
        static double SummDouble(double n, double m)
        {

            return n + m;
        }
    }
}