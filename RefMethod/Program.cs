using System;

namespace RefMethodsHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
        }
        #region Task1
        //         1. На входе дано три массива заполненных случайными числами. Написать метод 
        // по подсчёту общего количества чётных чисел в массивах. (ref)
        static void Task1()
        {
            int[] massivOne = { 0, 2, 3, 4, 5, 6, 7, 4, 234, 25 };
            int[] massivSecond = { 2, 1, 4, 5, 66, 9, 8, 4 };
            int[] massivFive = { 4, 6, 6, 7, 78, 88, 96, 6, 4, 7, 6 };
            int counter = 0;
            System.Console.WriteLine(counter);
        }
        void Count(ref int[] )
        {
            foreach (int t in massiv)
            {
                if (t % 2 == 0)
                {
                    counter
                }
            }
        }


        #endregion

    }
}