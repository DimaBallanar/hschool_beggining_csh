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

