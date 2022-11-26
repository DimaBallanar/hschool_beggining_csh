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
        // Task8();
        // Task9();
        // Task10();
        // Task11();
        // Task12();
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
}