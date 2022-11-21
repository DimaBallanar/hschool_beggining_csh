internal class Program
{
    static void Main(string[] args)
    {
        // Task1();
        Task2();
        // Task3();
        // Task4();
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
        userText = userText.ToLower();
        string[] massivText = userText.Split(' ');
        string result = "";
        for (int i = 0; i < massivText.Length; i++)
        {
            result += massivText[i].ToUpper() + " ";
            // char[] a =mass.ToCharArray();
            // char[0]=char[0].ToUpper();
        }
        return result;
    }
    static void Task2()
    {
        System.Console.WriteLine("введите любую строку");
        string userText = Console.ReadLine();
        System.Console.WriteLine(UpperLvl(userText));
    }
    #endregion

    #region Task 3
    static void Task3()
    {

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