using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task1();
            Task2();
            // Task3();
            // Task4();
        }
        #region Task1


        static void Task1()
        {
            int number1;
            number1 = 5;
            int number2 = 13;
            string opr = "+";

            System.Console.WriteLine(Switch(opr: opr, number1: number1, number2: number2));
            // System.Console.WriteLine(MethodSum(number1, number2));
            // System.Console.WriteLine(MethodDeference(number1, number2));
            // System.Console.WriteLine(MethodMultiplication(number1, number2));
            // System.Console.WriteLine(MethodDivision(number1, number2));
        }

        static int MethodSum(int number, int number1) => number + number1;
        static int MethodDeference(int number, int number1) => number - number1;
        static int MethodMultiplication(int number, int number1) => number * number1;
        static int MethodDivision(int number, int number1) => number / number1;

        static string Switch(int number1, int number2, string opr) => opr switch
        {
            "+" => MethodSum(number1, number2).ToString(),
            "-" => MethodDeference(number1, number2).ToString(),
            "*" => MethodMultiplication(number1, number2).ToString(),
            "/" => MethodDivision(number1, number2).ToString(),
            _ => string.Format("No resultations {0}", opr)
        };
        #endregion



        #region Task2
        // 2. Написать метод по рассчету средней скорости на участке и выводе сообщения
        // превысил водитель скорость или нет. Метод должен принимать во сколько
        // водитель въехал в участок контроля скорости и время во сколько выехал из
        // участка, в виде HH:MM:SS, длинну учатска контроля скорости и среднюю
        // допустимую скорость участка
        // В задаче использовать необязательные парметры, локальные методы
        static void Task2()
        {
            System.Console.WriteLine("введите во сколько водитель вьехал на участок в формате HH:MM:SS");
            string? timeInput = Console.ReadLine();
            System.Console.WriteLine("введите во сколько водитель выехал с участка в формате HH:MM:SS");
            string? timeOutput = Console.ReadLine();
            
            System.Console.WriteLine(Result(timeInput,timeOutput));

        }
        static string Result(string timeInput, string timeOutput, int distance = 10000, int normalSpeed = 25, int mass = 3)
        {
            int speedUser = distance / (TimeCount(timeOutput) - TimeCount(timeInput));
            if (speedUser > normalSpeed)
            {
                string result = "водитель не превысил скорость";
                return result;
            }
            else
            {
                string result = "водитель  превысил скорость";
                return result;
            }

            int TimeCount(string time)
            {
                string[] timeSec = time.Split(":");
                int[] timer = new int[mass];
                for (int i = 0; i < mass; i++)
                {
                    bool Input = int.TryParse(timeSec[i], out timer[i]);
                }
                int timeIn = timer[0] * 3600 + timer[1] * 60 + timer[2];
                return timeIn;
            }
        }
        #endregion

        #region  Task3

        // 3. Написать метод увеличению размера массива и заполнения его значениями
        // В задаче использовать необязательные парметры, локальные методы.
        static void Task3()
        {
            System.Console.WriteLine("есть массив ,который состоит из (12,stroker,i)");
            object[] dataMassiv = { 12, "stroker", 'i' };
            System.Console.WriteLine("на сколько хотите увеличить массив?");
            int p = Convert.ToInt32(Console.ReadLine());
            ParamMassiv(p, ref dataMassiv);
            System.Console.WriteLine(string.Join(",", dataMassiv));
            void ParamMassiv(int p, ref object[] dataMassiv, int g = 3)
            {
                ResultMassiv(p, ref dataMassiv);

                object[] ResultMassiv(int p, ref object[] dataMassiv)
                {
                    object[] newMass = new object[g + p];
                    Array.Copy(dataMassiv, newMass, g);

                    for (int i = g; i < g + p; i++)
                    {
                        System.Console.WriteLine("добавьте  значение в Ваш массив");
                        newMass[g] = Convert.ToString(Console.ReadLine());
                    }
                    dataMassiv = newMass;
                    return dataMassiv;
                }

            }
        }
        #endregion


        #region  Task4
        // 4. Написать метод по расчету корней квадратного уравнения с использованием
        // локального метода 

        static void Task4()
        {
            System.Console.WriteLine(" у нас есть квадратное уравнение вида ax^2+bx+с=0");
            System.Console.WriteLine("введите значение a:");
            int a = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("введите значение b:");
            int b = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("введите значение c:");
            int c = Convert.ToInt32(Console.ReadLine());
            SolveProblem(a, b, c, out double x1, out double x2, out string result);
            // System.Console.WriteLine(result, x1, x2);

        }
        static void SolveProblem(int a, int b, int c, out double x1, out double x2, out string result)
        {
            double discriminant = b * b - 4 * a * c;
            if (discriminant < 0)
            {
                result = "нет корней";
                x1 = x2 = 0;
                System.Console.WriteLine($"{result}");

            }
            else
            {
                Roots(a, b, c, out x1, out x2);
                result = "";
                if (x1 == x2)
                {
                    result = "один корень";
                    System.Console.WriteLine($"{result}:{x1}");
                }
                else
                {
                    result = "два корня";
                    System.Console.WriteLine($"{result}: x1={x1}, x2={x2}");

                }
            }
            void Roots(int a, int b, int c, out double x1, out double x2)
            {
                x1 = ((-b + Math.Sqrt(discriminant)) / (2 * a));
                x2 = ((-b - Math.Sqrt(discriminant)) / (2 * a));

            }

        }


        #endregion
    }
}