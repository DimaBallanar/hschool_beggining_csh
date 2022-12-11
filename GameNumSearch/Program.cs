using System;

namespace GameSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task();
        }
        #region Task
        // игра, в которой загадывается рандомное число от 1 до 100, угадывает компьютер и пользователь,побеждает тот,кто быстрее угадает.
        // добавить подсказки, в виде "ты рядом", "далек от истины" и прочее,чтобы поиск не затянулся.
        // чтобы помочь,также, создать массив, в который будут записываться числа с "попыток", при этом их сразу надо упорядочивать по возрастанию,чтобы не бегать глазами.
        // Аминь!
        static void Task()
        {
            System.Console.WriteLine("давайте попробуем отгадать число от 0 до 100");
            int rnd = Randomaizer();
            System.Console.WriteLine(rnd);
            Search(rnd, out int tryCount);
            System.Console.WriteLine($"загаданное число {rnd},  вы сделали {tryCount} попыток");
        }
        static int Randomaizer()
        {
            Random rnd = new Random();
            int numForSearch = rnd.Next(0, 100);
            return numForSearch;
        }
        static void Search(int rnd, out int tryCount)
        {
            string tries="ваши попытки:";
           int userTry = 0;
            tryCount = 0;
            for (int i = 0; i <= 110; i++)
            {
                tryCount++;
                System.Console.WriteLine("какое число загадал компьютер?");
                userTry = Convert.ToInt32(Console.ReadLine());
                tries+=userTry+",";
                if (userTry == rnd)
                {
                    break;
                }
                else if (userTry < rnd)
                {
                    System.Console.WriteLine("загаданное число больше");
                    System.Console.WriteLine(tries);

                }
                else
                {
                    System.Console.WriteLine("загаданное число меньше");
                    System.Console.WriteLine(tries);
                }

            }
        }
        static void ComputerSearch()
        {

        }

        #endregion
    }
}