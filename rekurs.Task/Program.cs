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
            System.Console.WriteLine("введите число");
            int number = Convert.ToInt32(Console.ReadLine());
            NumberDivider(number);
        }
        static void NumberDivider(int n)
        {
            if (n > 1)
            {
                NumberAraySimp(2, n);
            }
            else
            {
                Console.WriteLine("error input");
            }
        }
        static int NumberAraySimp(int num, int n)
        {
            if (num > n / 2)
            {
                return n;
            }
            if (n % num == 0 && IsNumSim(num, num / 2))
            {
                Console.Write($"{num} ");
            }
            return NumberAraySimp(num + 1, n);
        }
        static bool IsNumSim(int num, int dif)
        {
            if (dif <= 1)
            {
                return true;
            }
            else if (num % dif == 0)
            {
                return false;
            }
            return IsNumSim(num, dif - 1);
        }
        #endregion


        #region Task4
        // 4. Дано натуральное число больше 1 (вводится с клавиатуры). Выведите «Точная
        // степень двойки», если число является точной степенью двойки, или «Не
        // являеться степенью двойки», в противном случае используя рекурсию.
        static void Task4()
        {
            System.Console.WriteLine("введите натуральное число больше 1");
            int usNum = Convert.ToInt32(Console.ReadLine());
            // int usNum = 8;
            System.Console.WriteLine(FindTrue(usNum));
            string FindTrue(int number)
            {
                if (number % 2 == 0)
                {
                    number = number / 2;
                    return FindTrue(number);
                }
                else if (number == 1)
                {
                    return "точная степень двойки";
                }
                else return "Не является степенью двойки";
                // if (number == 1) return "точная степень двойки";
                // else return "Не является степенью двойки";
            }
        }

        #endregion


        #region Task5
        // 5. Написать метод возвращающий индекс максимального и минимального
        // значения массива (два способа используя кортеж и out).
        static void Task5()
        {
            int[] myMassiv = new int[] { 1, 2, -99, 13, 31, 75, 9 };
            OutFindMinMax(myMassiv, out int indexMin, out int indexMax);
            System.Console.WriteLine($"индекс минимального значения-{indexMin},индекс максимального значения-{indexMax}");
            System.Console.WriteLine(KorteghFound(myMassiv));
        }
        static void OutFindMinMax(int[] massiv, out int indexMin, out int indexMax)
        {
            int minValue = massiv[0];
            indexMin = 0;
            int maxValue = massiv[0];
            indexMax = 0;
            for (int i = 1; i < massiv.Length; i++)
            {
                if (maxValue < massiv[i])
                {
                    maxValue = massiv[i];
                    indexMax = i + 1;
                }
                if (minValue > massiv[i])
                {
                    minValue = massiv[i];
                    indexMin = i + 1;
                }
            }
        }
        static (int, int) KorteghFound(int[] massiv)
        {
            int minValue = massiv[0];
            int indexMinK = 0;
            int maxValue = massiv[0];
            int indexMaxK = 0;
            for (int i = 1; i < massiv.Length; i++)
            {
                if (maxValue < massiv[i])
                {
                    maxValue = massiv[i];
                    indexMaxK = i + 1;
                }
                if (minValue > massiv[i])
                {
                    minValue = massiv[i];
                    indexMinK = i + 1;
                }
            }
            return (indexMinK, indexMaxK);
        }

        #endregion


        #region Task6
        // 6. На входе 2 числа, написать метод по замене местами чисел в переменных, если
        // первое число кратно двум, второе не кратно двум и первое число меньше второго
        // (результат вернуть в виде кортежа)
        static void Task6()
        {
            int num1 = 2;
            int num2 = 98;
            System.Console.WriteLine(KorteghMix(num1, num2));
        }
        static (int, int) KorteghMix(int number1, int number2)
        {
            int number3 = number1;
            int number4 = number2;
            if (number1 % 2 == 0 && number2 % 2 != 0 && number1 < number2)
            {
                number4 = number1;
                number3 = number2;
            }
            return (number3, number4);
        }
        #endregion


        #region Task7
        // 7. Дана строка. Написать метод по подсчёту количеству вхождений символа
        // (подстроки). Метод возвращает символ (подстроку), количество вхождений, перое
        // и последнее вхождение в строку. (использовать IndexOf, LastIndexOf, Split и тд
        // запрещено)
        static void Task7()
        {
            System.Console.WriteLine("введите любую строку");
            // string? userInfo = Convert.ToString(Console.ReadLine());
            string userInfo = "приPVOвет как деPVOла";
            System.Console.WriteLine("введите вхождение");
            // string? userCheck = Convert.ToString(Console.ReadLine());
            string userCheck = "PVO";
            if (!string.IsNullOrEmpty(userInfo) && !string.IsNullOrEmpty(userCheck))
            {
                System.Console.WriteLine(CustomCount(userInfo, userCheck));
            }
            else
            {
                System.Console.WriteLine("Error");
            }
        }
        static (string, int, int, int) CustomCount(string text, string symbol)
        {
            int count = 0;
            int indexFirst = -1;
            int indexLast = -1;
            int LengthSymbol = symbol.Length;
            for (int i = 0; i <= text.Length - LengthSymbol; i++)
            {
                string temp = "";
                for (int j = i; j <= i + (LengthSymbol - 1); j++)
                {
                    temp += text[j];
                }
                if (temp == symbol)
                {
                    if (indexFirst == -1)
                    {
                        indexFirst = i;
                    }
                    indexLast = i;
                    count++;
                }
            }
            return (symbol, count, indexFirst, indexLast);
        }
        #endregion

    }
}



