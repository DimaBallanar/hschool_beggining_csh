internal class Program
{
    static void Main(string[] args)
    {
        // Task1();
        // Task2();
        // Task3();
        Task4();
    }

    #region Task 1
    // пользователь вводит числа, найти наибольшее

    static void Task1()
    {
        int num1 = 7;
        int num2 = 5;
        int num3 = 3;
        System.Console.WriteLine(HelloBro(num1, num2, num3));
    }
    static int HelloBro(int num1, int num2, int num3)
    {
        if (num1 < num2 && num1 < num3)
        {
            if (num2 > num3)
            {
                return num2;
            }
            else
            {
                return num3;
            }
        }
        return num1;
    }
    #endregion
    #region Task 2
    // написать метод по подсчету вхождения символа в строку

    static void Task2()
    {
        string text = "привет пзрфы фы зфш фруру фурзугфкф";
        char symb = 'п';
        System.Console.WriteLine(Count(text, symb));
    }
    static int Count(string text, char input)
    {
        int count = 0;
        foreach (char tex in text)
        {
            if (tex == input)
            {
                count++;
            }
        }
        return count;
    }
    #endregion
    #region Task 3
    // написать метод который разворачивает строку задом наперед

    static void Task3()
    {
        string text = "привет";
        System.Console.WriteLine(Reverse(text));
    }
    static string Reverse(string text)
    {
        string result = "";
        for (int i = text.Length - 1; i > -1; i--)
        {
            result += text[i];
        }
        return result;
    }
    #endregion
    #region Task 4
    // найти индекс минимального значения числа массива

    static void Task4()
    {
        int[] value = new int[] { 1, 3, 4, 5, 76, 7, 43, 342, 1231, 3 };
        System.Console.WriteLine(MaxValue(value));
    }
    static int MaxValue(int[] value)
    {
        int result = 0;
        int second = 0;
        for (int i = 0; i < value.Length; i++)
        {
            if (second < value[i])
            {
                second = value[i];
                result = i;
            }
        }
        return result;
    }
    #endregion


}
internal class Program1
{

    static void Main()
    {
        CalculateNumbers((double)6M, 4.4);
    }

    static void CalculateNumbers(double number1, double number2)
    {
        System.Console.WriteLine(number1 + number2);
    }
}
internal class Program3
{
    static void Counter(int value) 
    {
        value++; 
        System.Console.WriteLine(value);
    }

    static void Main()
    {
        int number = 1;
        System.Console.WriteLine(number);
        Counter(number); // int value = (number = 1) => int value  = 1;
        System.Console.WriteLine(number);
        Counter(number); // int value = (number = 1) => int value  = 1;
    }
}
internal class Program4
{
    static void Counter(ref int value) //int number с строчки 11 
    {
        value++; 
        System.Console.WriteLine(value);
    }

    static void Main()
    {
        int number = 10;
        System.Console.WriteLine(number);
        Counter(ref number);
        System.Console.WriteLine(number);
        Counter(ref number);
    }
}

internal class Program5
{
    static void Main()
    {
        // CalculareNambers(6L, 6F);
        int number = 5;
        int step = 7;
        Move(ref number, step);
        Move(ref number, step);
        Move(ref number, step);
        Move(ref number, step);
        Move(ref number, step);
        Move(ref number, step);
        System.Console.WriteLine(number);
    }

    static void Move(ref int number, int step)
    {
        number += step;
        // System.Console.WriteLine(number1 + number2);
    }
}

internal class Program6
{
    static bool Parse(string text, char separator, out string name, out string age)
    {
        string[] result = text.Split(separator);
        if (result.Length == 2)
        {
            name = result[0];
            age = result[1];
            return true;
        }

        name = "";
        age = "";
        return false;
    }

    static void Main()
    {
        Parse("text_21", '_', out string name, out string age);
        System.Console.WriteLine("name - {0} age = {1}", name, age);
    }

     static void Task5()
    {
        string input = "Hello askdjhasd oaisd/ 213 123/sdf sdf/sdf";
        char symbol = ' ';
        bool result = Method1(input, symbol, out int count);
        Console.WriteLine(string.Format("Symbol - {0}, length new array - {1}", symbol, count));
    }
    static bool Method1(string text, char symbol, out int count)
    {
        if (text.IndexOf(symbol) > -1)
        {
            count = text.Split(symbol).Length;
            return true;
        }
        count = 0; // default
        return false;

    }
}
