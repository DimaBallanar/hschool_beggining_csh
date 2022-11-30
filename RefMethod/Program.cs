using System;

namespace RefMethodsHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task1();
            Task2();
        }
        #region Task1
        //         1. На входе дано три массива заполненных случайными числами. Написать метод 
        // по подсчёту общего количества чётных чисел в массивах. (ref)
        static void Task1()
        {
            int[] massivOne = { 1, 2, 3, 4, 5, 6, 7, 4, 234, 25 };
            int[] massivSecond = { 2, 1, 4, 5, 66, 9, 8, 4 };
            int[] massivFive = { 4, 6, 6, 7, 78, 88, 96, 6, 4, 7, 6 };
            int counter = 0;
            System.Console.WriteLine(Count(massivOne, ref counter));
            System.Console.WriteLine(Count(massivSecond, ref counter));
            System.Console.WriteLine(Count(massivFive, ref counter));
        }
        // void Counter(ref int counter)
        // {
        //     counter++;
        // }
        static int Count(int[] massiv, ref int counter)
        {
            foreach (int t in massiv)
            {
                if (t % 2 == 0 && t != 0)
                {
                    counter++;
                }
            }
            return counter;
        }


        #endregion

        #region Task2();
        //         2. Написать метод, который проверяет является ли введнная строка почтовым
        // адрессом и возвращающий домен почты.(out)
        static void Task2()
        {
            System.Console.WriteLine("введите свою почту");
            string? userMail = Console.ReadLine();
            if (!string.IsNullOrEmpty(userMail))
            {
                
               System.Console.WriteLine(MailParser(out string domen));

            }
            else
            {
                System.Console.WriteLine("ERROR");
            }
        }
        void MailParser(string userMail, out string domen)
        {
            string[] domenParse = { "@gmail", "@yandex", "@yahoo", "@outlook", "@protonmail", "@tut" };
            userMail.ToLower();
            foreach (string t in domenParse)
            {
                if (userMail.Contains(t))
                {

                    domen = userMail.Remove(userMail.IndexOf("."));
                }
            }
        }

        #endregion

    }
}