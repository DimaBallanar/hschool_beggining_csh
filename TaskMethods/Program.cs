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
        Task11();
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

    #region Task6
    // 6. На входе n – количество элементов массива (вводится с клавиатуры). Далее
    // производится заполнение массива с слуйчными числами. Реализуйте методы
    // подсчета количества элементов массива меньше и больш среднего значения. 
    static void Task6()
    {
        System.Console.WriteLine("введите количество элементов массива");
        string? n = Console.ReadLine();
        if (!string.IsNullOrEmpty(n))
        {
            int[] massivPull = new int[Convert.ToInt32(n)];
            Random rnd = new Random();
            for (int i = 0; i < massivPull.Length; i++)
            {
                massivPull[i] = rnd.Next(-100, 100);
            }
            int sumMassiv = 0;
            foreach (int mass in massivPull)
            {
                sumMassiv += mass;
            }
            int result = sumMassiv / Convert.ToInt32(n);
            System.Console.WriteLine(More(massivPull, result));
            System.Console.WriteLine(Less(massivPull, result));
            static int More(int[] massivPull, int result)
            {
                int m = 0;

                foreach (int mass in massivPull)
                {
                    if (mass > result)
                    {
                        m += 1;
                    }
                }
                return m;
            }
            static int Less(int[] massivPull, int result)
            {
                int m = 0;

                foreach (int mass in massivPull)
                {
                    if (mass < result)
                    {
                        m += 1;
                    }
                }
                return m;
            }
        }
        else
        {
            System.Console.WriteLine("null");
        }
    }
    #endregion

    #region Task7
    // 7. На входе массив. Реализуйте 2 метода. Первый для проверки, что в массиве
    // только числа. Второй для получения суммы всех элементов массива. Если
    // результат метода проверки – true, то вызывать новый метод, возвращающий
    // сумму всех элементов массива
    static void Task7()
    {
        System.Console.WriteLine("введите размер массива");
        int n = Convert.ToInt32(Console.ReadLine());
        string[] massivUser = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"введите {i} элемент массива");
            massivUser[i] = Console.ReadLine();
        }
        if (CheckNumber(massivUser))
        {
            System.Console.WriteLine(sumMassiv(massivUser));
        }
        else
        {
            System.Console.WriteLine("массив содержит не цифры");
        }
    }
    static bool CheckNumber(string[] massivUser)
    {
        foreach (string mass in massivUser)
        {
            if (!int.TryParse(mass, out int number))
            {
                return false;
            }
        }
        return true;
    }
    static int sumMassiv(string[] massivUser)
    {
        int check = 0;
        foreach (string sum in massivUser)
        {
            check += Convert.ToInt32(sum);
        }
        return check;
    }

    #endregion

    #region 8
    //     8. На входе массив. Реализуйте 2 метода. Первый для проверки, что в массиве
    // только строки. Второй для получения суммы всех строчных элементов массива.
    // Если результат метода проверки – true, то вызывать новый метод, возвращающую
    // конкатенацию всех строчных элементов массива
    static void Task8()
    {
        object[] textMassiv = new object[] { "sdsddsdsd", "sdsdda", "5", "+", " " };
        if (ResultParse(textMassiv))
        {
            string textEnter = "";
            foreach (object text in textMassiv)
            {
                textEnter += text;
            }
            System.Console.WriteLine(TextParseLower(textMassiv));
        }
        else
        {
            System.Console.WriteLine("содержит не только строки");
        }

    }
    static bool ResultParse(object[] textMassiv)
    {
        foreach (object text in textMassiv)
            if (text.ToString().Length < 2)      // надо записать правильное условие на проверку строки
            {
                return false;
            }
        return true;
    }

    static string TextParseLower(object[] textMassiv)
    {
        string textEnter = "";
        string resultText = "";
        foreach (object text in textMassiv)
        {
            textEnter += text;
        }
        for (int i = 0; i < textEnter.Length; i++)
        {
            if (char.IsLower(textEnter[i]))
            {
                resultText += textEnter[i];
            }
        }
        return resultText;
    }





    #endregion


    #region  Task9
    // 9. На входе 2 массива, размерность которых вводится с клавиатуры, а значения
    // заполняются случайными числами. Реализуйте 2 метода. Первый что массивы
    // имеют одинаковую размерность и все элементы отличаются. Второй произвести
    // поэлементное умножение. Если результат метода проверки – true, то вызывать
    // новый метод, возвращающий вывод элементов через запятую 
    static void Task9()
    {
        int lenght1 = Convert.ToInt32(Console.ReadLine());
        int[] numbers1 = new int[lenght1];
        for (int i = 0; i < lenght1; i++)
        {
            numbers1[i] = new Random().Next(-100, 100);
        }
        System.Console.WriteLine(string.Join(", ", numbers1));
        int lenght2 = Convert.ToInt32(Console.ReadLine());
        int[] numbers2 = new int[lenght2];
        for (int i = 0; i < lenght2; i++)
        {
            numbers2[i] = new Random().Next(-100, 100);
        }
        System.Console.WriteLine(string.Join(", ", numbers2));
        if (MethodLenght(numbers1, numbers2))
        {
            System.Console.WriteLine(MethodMultiplicationItems(numbers1, numbers2));
        }
        else
        {
            System.Console.WriteLine("error");
        }
    }

    static bool MethodLenght(int[] number1, int[] number2)
    {
        if (number1.Length != number2.Length)
        {
            return false;
        }
        for (int i = 0; i < number1.Length; i++)
        {
            if (number1[i] == number2[i])
            {
                return false;
            }
        }
        return true;
    }
    static string MethodMultiplicationItems(int[] number1, int[] number2)
    {
        int[] result = new int[number1.Length];
        for (int i = 0; i < number1.Length; i++)
        {
            result[i] = number1[i] * number2[i];
        }
        return string.Join(", ", result);
    }

    #endregion


    #region Task10
    // 10. На входе массив. Реализуйте 2 метода. Первый для проверки, что в массиве
    // только числа. Второй для получения только четных элементов массива. Если
    // результат метода проверки – true, то вызывать новую метод, возвращающий
    // массив с четными элементами массива

    static void Task10()
    {
        object[] massivQueen = { "3", "367", "3", "3", "5", "3", "3", "6" };
        if (MethodEquals(massivQueen))
        {
            System.Console.WriteLine(string.Join(",", ParaNumbers(massivQueen)));
        }
        else
        {
            System.Console.WriteLine("не только числа");
        }
    }
    static bool MethodEquals(object[] massivQueen)
    {
        foreach (object mass in massivQueen)
        {
            if (!int.TryParse(mass.ToString(), out int number))
            {
                return false;
            }
        }
        return true;
    }
    static string[] ParaNumbers(object[] massivQueen)
    {
        string[] result = new string[massivQueen.Length];
        for (int i = 0; i < massivQueen.Length; i++)
        {
            if (Convert.ToInt32(massivQueen[i]) % 2 == 0)
            {
                result[i] += massivQueen[i];
            }
            else
            {
                result[i] += " ";
            }

        }
        // string result1=string.Join(",",result).Split('',StringSplitOptions.RemoveEmptyEntries);
        return result;
    }



    #endregion

    #region Task11
    //11. На входе число. Необходимо создать метод, возвращающий факториал числа.
    //Пример фактериала 4! = 1 * 2 * 3 * 4

    static void Task11()
    {
        System.Console.WriteLine("Введите любое число,а мы посчитаем его факториал");
        int number = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine($"факторил вашего числа {number} является {FactorialCount(number)}");
    }
    static int FactorialCount(int number)
    {
        int result = 1;
        for (int i = 1; i <= number; i++)
        {
            result = result * i;
        }
        return result;
    }


    #endregion
    #region Task12
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



}