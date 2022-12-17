using System;

namespace TaskHard // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите число 1:");
            int.TryParse(Console.ReadLine(), out int number1);
            Console.Write("введите число 2:");
            int.TryParse(Console.ReadLine(), out int number2);

            int result = number1 + number2;
            System.Console.WriteLine(result);


        }
    }
}