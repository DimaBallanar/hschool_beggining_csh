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
int rnd=Randomaizer();

}
static int Randomaizer()
{
    Random rnd=new Random();
    int numForSearch=rnd.Next(0,100);
    return numForSearch;
}
static int Search(int rnd)
{
    int tryCount=0;
    System.Console.WriteLine();
}

#endregion
    }
}