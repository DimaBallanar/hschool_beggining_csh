using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task1();
            // Task2();
            Task3();
            // Task4();
            // Task5();
            // Task6();
            // Task7();
        }
        #region Task1
        //     1. Написать метод, рассчитывающий число из ряда Фиббоначчи используя
        // рекурсию (формула Фн=Фн-1+Фн-2)(0,1,1,2,3,5,8,13,21...)
        static void Task1()
        {
            System.Console.WriteLine("введите номер элемента с ряда Фиббоначчи");
            int cost = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine(FibNumber(cost));
        }
        static int FibNumber(int cost)
        {
            if (cost == 1)
            {
                return 0;
            }
            if (cost == 2 || cost == 3)
            {
                return 1;
            }
            return FibNumber(cost - 1) + FibNumber(cost - 2);
        }

        #endregion


        #region Task2
        //2. Дано натуральное число (вводится с клавиатуры). Вычислите сумму его цифр
        // используя рекурсию
        static void Task2()
        {
            System.Console.WriteLine("введите натуральное число");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            // int userNumber = 12;
            if (userNumber > 0)
                System.Console.WriteLine(SummNumbers(userNumber));
            else
                System.Console.WriteLine("error");
        }
        static int SummNumbers(int userNumber)
        {
            int result = 0;
            result += userNumber % 10;
            userNumber = userNumber / 10;
            if (userNumber > 0)
            {
                result += SummNumbers(userNumber);
            }
            return result;
        }


        #endregion

        #region Task3
        // 3. Дано натуральное число больше 1 (вводится с клавиатуры). Выведите все простые
        // делители этого числа используя рекурсию 
        static void Task3()
        {
            System.Console.WriteLine("введите число больше 1");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            if (number > 1)
            {
                System.Console.WriteLine(DivNumbers(number, ref result));
            }
            else
            {
                System.Console.WriteLine("ввели число ,меньше заданого по условию");
            }
        }
        static int DivNumbers(int number, ref int result)
        {
            result += 1;
            if (number % result == 0 && number >= result)
            {
                System.Console.WriteLine(result);

                return DivNumbers(number, ref result);
            }

            return number;
        }
        #endregion


        #region Task4
        // 4. Дано натуральное число больше 1 (вводится с клавиатуры). Выведите «Точная
        // степень двойки», если число является точной степенью двойки, или «Не
        // являеться степенью двойки», в противном случае используя рекурсию.


        #endregion


        #region Task5
        // 5. Написать метод возвращающий индекс максимального и минимального
        // значения массива (два способа используя кортеж и out).

        #endregion


        #region Task6
        // 6. На входе 2 числа, написать метод по замене местами чисел в переменных, если
        // первое число кратно двум, второе не кратно и первое число меньше двух
        // (результат вернуть в виде кортежа)

        #endregion


        #region Task7
        // 7. Дана строка. Написать метод по подсчёту количеству вхождений символа
        // (подстроки). Метод возвращает символ (подстроку), количество вхождений, перое
        // и последнее вхождение в строку. (использовать IndexOf, LastIndexOf, Split и тд
        // запрещено)


        #endregion

    }
}



