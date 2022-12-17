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


            static double SummDouble(double n, double m)
            {

                return n + m;
            }
        }
    }
}