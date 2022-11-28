internal class Program
{
    static void Main(string[] args)
    {
        // Task1();
        // Task2();
        // Task3();
        // Task4();
        // Task5();
        // Task6();
        // Task7();
        // Task8();
        // Task9();
        // Task10();
        // Task11();
        Task12();
        // Task13();
        // Task14();
        // Task15();

    }

    #region Task 1
    // 1. Пользователь вводит имя и фамилию. Необходимо создать метод возвращающую
    // строку вида «Привет, {имя} {фамилия}»
    static string HelloBro(string name, string surname)
    {
        return $"Привет,{name} {surname}";
    }
    static void Task1()
    {
        System.Console.WriteLine("введите свое имя");
        string name = Console.ReadLine();
        System.Console.WriteLine("введите свою фамилию");
        string surname = Console.ReadLine();
        System.Console.WriteLine(HelloBro(name, surname));
    }
    #endregion

    #region Task 2

    //     2. Напишите метод, который принимает строку в маленьком регистре и возаращает
    // строку, где каждое слово начинается с большого регистра
    // hschool company -> Hschool Company 
    static string UpperLvl(string userText)
    {
        // userText = userText.ToLower();
        // string userText1 = userText.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        string[] massivText = userText.Split(' ');
        string result = "";
        for (int i = 0; i < massivText.Length; i++)
        {
            string five = massivText[i];
            string liter = Convert.ToString(five[0]).ToUpper();
            result += liter.ToUpper() + massivText[i].Remove(0, 1) + " ";

        }
        return result;
    }
    static void Task2()
    {
        System.Console.WriteLine("введите любую строку");
        string? userText = Console.ReadLine().ToLower();
        // string userText = " hello my little worls";
        System.Console.WriteLine(UpperLvl(userText));
    }
    #endregion

    #region Task 3
    //     3. Напишите метод, который принимает статичный массив строк. Необходимо
    // отфильтровать значения и оставить только те, где длина строк до 2 символов.
    // [“by”, “belarus”, “de”, “ru”, “germany”] -> [“by”, “de”, “ru”]

    static void Task3()
    {
        string[] massivText = new string[] { "by", "belarus", "de", "ru", "germany" };
        System.Console.WriteLine(CheckStroker(massivText));
    }

    static string CheckStroker(string[] massivText)
    {
        // string[] result = new string[massivText.Length];
        string result = "";
        for (int i = 0; i < massivText.Length; i++)
        {
            if (massivText[i].Length <= 2)
            {
                result += string.Concat(massivText[i], ",");
            }

        }

        // return string.Join(',', result);
        return result;
    }

    #endregion

    #region Task 4
    //     4. На входе массив. Реализовать метод проверки на то что в массиве только числа.
    // Метод возвращает true, если в массиве только числа и false в противном случае

    static void Task4()
    {
        object[] array = new object[] { 1, 2, 3 };
        System.Console.WriteLine(CheckNumber(array));

    }

    static bool CheckNumber(object[] array)
    {
        foreach (object obj in array)
        {
            if (obj is not int)
            {
                return false;
            }

        }
        return true;
    }
    #endregion



    #region Task5

    // 5. На входе n – количество элементов массива (вводится с клавиатуры). Далее
    // производится заполнение массива с слуйчными числами. Реализуйте два метода
    // для поиска минимального и максимального значения. 


    static void Task5()
    {
        System.Console.WriteLine("введите размер массива");
        int res = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine(MinNumberMass(res));
        System.Console.WriteLine(MaxNumberMass(res));
    }

    static int MinNumberMass(int res)
    {
        int[] massivNumbers = new int[res];
        Random rnd = new Random();
        foreach (int mass in massivNumbers)
        {
            massivNumbers[mass] = rnd.Next();
        }
        int minValue = massivNumbers.Min();
        return minValue;
    }
    static int MaxNumberMass(int res)
    {
        int[] massivNumbers = new int[res];
        Random rnd = new Random();
        foreach (int mass in massivNumbers)
        {
            massivNumbers[mass] = rnd.Next();
        }
        int maxValue = massivNumbers.Max();
        return maxValue;
    }
    #endregion

    #region 12
    //     12. На входе строка. Необходимо создать метод, возвращающий true, если это слово
    // палиндром и false в противном случае
    static void Task12()
    {
        System.Console.WriteLine("введите слово");
        string? userText = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(userText))
        {
            System.Console.WriteLine(Palindrom(userText));
        }
    }
    static bool Palindrom(string userText)
    {
        for (int i = 0; i < userText.Length; i++)
        {
            if (userText[i] != userText[userText.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
    #endregion


    //  #region Task9

    //     9. На входе 2 массива, размерность которых вводится с клавиатуры, а значения
    // заполняются случайными числами. Реализуйте 2 метода. Первый что массивы
    // имеют одинаковую размерность и все элементы отличаются. Второй произвести
    // поэлементное умножение. Если результат метода проверки – true, то вызывать
    // новый метод, возвращающий вывод элементов через запятую 


    // static void Task9()
    // {

    // }

    // static int (int res)
    // {

    //     return maxValue;
    // }
    // #endregion
}