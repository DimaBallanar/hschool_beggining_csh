﻿using System;

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
            // System.Console.WriteLine(rnd);
            Search(rnd, out int tryCount);
            System.Console.WriteLine($"загаданное число {rnd},  вы сделали {tryCount} попыток");
            ComputerSearch(rnd, out int tryCompCount);
            System.Console.WriteLine($"загаданное число {rnd},  комп сделал {tryCompCount} попыток");
            if (tryCount > tryCompCount)
            {
                System.Console.WriteLine("победа за ИИ");
            }
            else if (tryCompCount > tryCount)
            {
                System.Console.WriteLine("победил игрок");
            }
            else
            {
                System.Console.WriteLine("дружеская ничья");
            }
        }
        static int Randomaizer()
        {
            Random rnd = new Random();
            int numForSearch = rnd.Next(0, 1000);
            return numForSearch;
        }
        static void Search(int rnd, out int tryCount)
        {
            string tries = "ваши попытки:";
            int userTry = 0;
            tryCount = 0;
            int i = 0;
            for (; ; i++)
            {
                tryCount++;
                System.Console.WriteLine("какое число загадал компьютер?");
                userTry = Convert.ToInt32(Console.ReadLine());
                tries += userTry + ",";
                if (userTry == rnd)
                {
                    System.Console.WriteLine(tries);
                    break;
                }
                else if (userTry < rnd)
                {
                    System.Console.WriteLine("Слишком мало, попробуйте еще раз");
                    System.Console.WriteLine(tries);

                }
                else
                {
                    System.Console.WriteLine("Слишком много, попробуйте еще раз");
                    System.Console.WriteLine(tries);
                }

            }
        }
        static void ComputerSearch(int rnd, out int tryCompCount)
        {
            Random rand = new Random();
            tryCompCount = 0;
            int tryCompNum;
            string computerTries = "попытки компа:";
            int min = 0;
            int max = 1000;
            int i = 0;
            for (; ; i++)
            {

                tryCompNum = rand.Next(min, max);
                tryCompCount++;
                computerTries += tryCompNum + ",";
                if (tryCompNum == rnd)
                {
                    System.Console.WriteLine(computerTries);
                    break;
                }
                else if (tryCompNum > rnd)
                {
                    max = tryCompNum - 1;
                }
                else
                {
                    min = tryCompNum + 1;
                }
            }

        }

        #endregion
    }
}