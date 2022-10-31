﻿// 1. Ввести строку. Если эта равна “hschool”, вывести true. В противном случае false.
// Добавить проверки для строк. Удалить лишние пробелы

{
    string? textEnter = Console.ReadLine();

    if (!string.IsNullOrEmpty(textEnter))
    {
        if (textEnter.ToLower().Trim() == "hschool")
        {
            // bool result= textEnter.ToLower().Trim() == "hschool";
            System.Console.WriteLine(textEnter.ToLower().Trim() == "hschool");
        }
        else
        {
            System.Console.WriteLine(false);
        }
    }
    else
    {
        System.Console.WriteLine("вы ввели не строку");
    }
}

// 2. Ввести строку. Проверить является ли это число или строка. Если число, то
// выяснить, четное или нет. Если это строка то преобразовать строку в массив, где
// каждый символ – один элемент массива
// ‘hschool’ => [‘h’, ‘s’, ‘c’, ‘h’, ‘o’, ‘o’, ‘l’]

{
    System.Console.WriteLine("введите строку");
    String? textUser = Console.ReadLine();
    if (!string.IsNullOrEmpty(textUser))
    {
        if (double.TryParse(textUser, out double number))
        {
            Console.WriteLine(number % 2 == 0 ? "четное число" : "не четное число");
        }
        else
        {
            char[] result = textUser.ToCharArray();
            Console.WriteLine(result.Length);
        }
    }

}
// 3. Преобразовать строку ‘Full сStaCK DevELoper’ в массив вида [‘full, ‘stack’,
// ‘developer’]
{
    string textUser = "Full сStaCK DevELoper";
    textUser = textUser.ToLower();
    string[] result = textUser.Split(' ');
    System.Console.WriteLine(result[0]);
    System.Console.WriteLine(result[1]);
    System.Console.WriteLine(result[2]);
}

// 4. Ввести строку. Проверить на isNaN. Если число, то ошибка ввода. Если это строка
// то узнать какая у нее длина. Привести к одному регистру, убрать лишние пробелы
{

    System.Console.WriteLine("введите строку");
    string? userText = Console.ReadLine();
    if (!string.IsNullOrEmpty(userText))
    {
        if (int.TryParse(userText, out int number))
        {
            System.Console.WriteLine("ошибка ввода");
        }
        else
        {
            System.Console.WriteLine($"символов в строке: {userText.Length}");
            System.Console.WriteLine(userText.ToLower());
            System.Console.WriteLine(string.Join(" ", userText.Split(' ', StringSplitOptions.RemoveEmptyEntries)));   //// вопросики,еще раз обьяснить как работает это комбо команд
        }
    }
}
// 5. ‘HTML JavaScript PHP’ преобразовать в "HTML-JAVASCRIPT-PHP"

string userStas = "HTML JavaScript PHP";
userStas = userStas.ToUpper();
System.Console.WriteLine(userStas.Replace(" ", "-"));


// 6. Ввести строку. Проверить является ли это число или строка. Если число, то ошибка ввода. Если это строка то первый символ поставить в верхний регистр.
// Убрать лишние пробелы

System.Console.WriteLine("введите свою строку");
string? inputText = Console.ReadLine();
inputText=inputText?.Trim();
if (!string.IsNullOrEmpty(inputText))
{
    if (int.TryParse(inputText, out int numberText))
    {
        System.Console.WriteLine("ошибка ввода");
    }
    else
    {
        string liter = Convert.ToString(inputText[0]);
        liter = liter.ToUpper();
        // inputText = liter + inputText.Remove(0, 1);
        System.Console.WriteLine(String.Concat(liter,inputText.Remove(0,1)));
    }
}

// 7. На вход программе подаётся строка. Замените все @ на '!' с помощью
// глобального поиска и замены (2 способа)

// 1 способ
{
    System.Console.WriteLine("введите строку");
    string? inputMessage = Console.ReadLine();
    if (!string.IsNullOrEmpty(inputMessage))
    {
        Console.WriteLine(inputMessage.Replace('@', '!'));
    }
    else
    {
        System.Console.WriteLine("null");
    }
}
// 2 способ
// {
//     System.Console.WriteLine("введите строку");
// string? inputMessage = Console.ReadLine();
// if (!string.IsNullOrEmpty(inputMessage))
// }



//8. Дана строка 'aaa bbb ccc'. Вырежите из нее слово 'bbb'
{
    string Text = "aaa bbb ccc";
    System.Console.WriteLine(Text.Remove(4, 4));
}

//9. На вход программе подается переменная date, в котрой лежит дата в формате
// 'xxxx-xx-xx'. Преобразуйте эту дату в формат 'xx/xx/xxxx’. (reverse)

System.Console.WriteLine("введите дату в формате год.месяц.день");
string? date = Convert.ToString(Console.ReadLine());
if (!string.IsNullOrEmpty(date))
{
    string[] dates = date.Split('.');
    System.Console.WriteLine($"{dates[2]}/{dates[1]}/{dates[0]}");
}
else
{
    System.Console.WriteLine("вы ввели не в заданном формате");
}


// 10. Дана строка из 3 слов разделенных пробелом:
// • Найдите количество символов в этой строке.
// • Вырежите из нее 2 и 3 слова.
// • Найдите индекс 2 подстроки

string userTextWords = "fruct vegetable bicycle";
int textLength = userTextWords.Length;
System.Console.WriteLine(textLength);
System.Console.WriteLine(userTextWords.Remove(5));
System.Console.WriteLine(userTextWords.IndexOf("vegetable"));

//11.Пользователь вводит дату в формате ‘х-х-х'. Замените все дефисы на '!'

System.Console.WriteLine("введите дату в формате хх-хх-хххх");
string? dataType = Console.ReadLine();
Console.WriteLine(dataType?.Replace('-', '!') ?? default);

// 12 Пользователь вводит дату в формате 'xxxx-xx-xx'. Преобразуйте эту дату в формат 'xx.xx.xxxx'.


System.Console.WriteLine("введите год");
string? dataUsera = Console.ReadLine() + "-";
System.Console.WriteLine("введите месяц");
dataUsera += Console.ReadLine() + "-";
System.Console.WriteLine("введите число месяца");
dataUsera += Console.ReadLine();
string[] dateBirthday = dataUsera.Split('-');
System.Console.WriteLine($"{dateBirthday[2]}.{dateBirthday[1]}.{dateBirthday[0]}");


// 13 Дан массив ['я', 'учу', 'javascript', '!']. С помощью метода join преобразуйте массив в строку 'я+учу+javascript+!'.


string[] massivStasa = { "я", "учу", "javascript", "!" };
System.Console.WriteLine(string.Join("+", massivStasa));


// 14 Дан массив. Вывести каждый отдельный элемент в консоль (for)

string[] massivLanguage = { "огурец", "помидоры", "железобетон", "34", "линейка на 30см" };                  //просто перебор,с циклом фор все проще
Console.WriteLine(massivLanguage[0]);
Console.WriteLine(massivLanguage[1]);
Console.WriteLine(massivLanguage[2]);
Console.WriteLine(massivLanguage[3]);
Console.WriteLine(massivLanguage[4]);

// 15 На вход программе подается строка текста, состоящая из слов, разделенных
// ровно одним пробелом. Напишите программу, которая подсчитывает количество слов в ней

System.Console.WriteLine("введите любой текс");
string? sochinenie = Console.ReadLine();
string[] calculateWords = sochinenie.Split(" ");
System.Console.WriteLine(calculateWords.Length);

// 16 Пользователь вводит строку. Необходимо посчитать количество гласных (for)



{
    System.Console.WriteLine(" введите любую строку");
    string? textUsera = Console.ReadLine();
    textUsera = textUsera.ToLower();
    Console.WriteLine($"{textUsera.Split('а', 'о', 'и', 'ы', 'у', 'э', 'я', 'ё', 'е', 'ю').Length - 1}");
}

//17Пользователь вводит строку. Необходимо посчитать количество согласных (for)

{
    System.Console.WriteLine(" введите любую строку");
    string? textUsera = Console.ReadLine();
    textUsera = textUsera.ToLower();
    Console.WriteLine($"{textUsera.Split('б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ').Length - 1}");
}

// 18.Пользователь вводит строку. Необходимо вывести все гласные отдельной строкой (for)
// fullstack => ua
{
    System.Console.WriteLine(" введите любую строку");
    string? textUsera = Console.ReadLine();
    textUsera = textUsera.ToLower();
    // System.Console.WriteLine(textUsera.Replace($"[бвгджзйклмнпрстфхцчшщ]", " "));
    // System.Console.WriteLine(textUsera.Split(' ').s);
    textUsera = textUsera.Replace("б", "");
    textUsera = textUsera.Replace("в", "");
    textUsera = textUsera.Replace("г", "");
    textUsera = textUsera.Replace("д", "");
    textUsera = textUsera.Replace("ж", "");
    textUsera = textUsera.Replace("з", "");
    textUsera = textUsera.Replace("й", "");
    textUsera = textUsera.Replace("к", "");
    textUsera = textUsera.Replace("л", "");
    textUsera = textUsera.Replace("м", "");
    textUsera = textUsera.Replace("н", "");
    textUsera = textUsera.Replace("п", "");
    textUsera = textUsera.Replace("р", "");
    textUsera = textUsera.Replace("с", "");
    textUsera = textUsera.Replace("т", "");
    textUsera = textUsera.Replace("ф", "");
    textUsera = textUsera.Replace("х", "");
    textUsera = textUsera.Replace("ц", "");
    textUsera = textUsera.Replace("ч", "");
    textUsera = textUsera.Replace("ш", "");
    textUsera = textUsera.Replace("щ", "");
    System.Console.WriteLine(textUsera);
}


// 19.19. На вход программе подается строка. Преобразуйте первую букву каждого слова
// строки в верхний регистр (for)


// 20.20.На вход программе подается строка, где каждое слово заканчивается “_”.
// Программа должна убрать “_” и первую букву каждого слова (помимо первого),
// преобразовать в верхний регистр (for)


// 21. На вход программе подается строка, состоящая из имени и фамилии человека,
// разделенных одним пробелом. Напишите программу, которая проверяет, что имя
// и фамилия начинаются с заглавной буквы.
// Chris Alan => true
// chris alan => false

{
    System.Console.WriteLine("введите Имя и Фамилию");
    string? nameSurName = Console.ReadLine();
    if (!string.IsNullOrEmpty(nameSurName))
    {
        string[] name = nameSurName.Split(" ");
        string name1 = name[0];
        char name10 = name1[0];
        System.Console.WriteLine(name10);
        string name2 = name[1];
        char name20 = name2[0];
        System.Console.WriteLine(name20);
        if (Char.IsUpper(name10) && Char.IsUpper(name20))
        {
            System.Console.WriteLine($"{nameSurName}=>true");
        }
        else
        {
            System.Console.WriteLine($"{nameSurName}=>false");
        }
    }
    else
    {
        System.Console.WriteLine("null");
    }
}

// 22. На вход программе подается строка. Напишите программу, которая меняет
// регистр символов, другими словами замените все строчные символы заглавными
// и наоборот. Swap Case => sWAP cASE

{

}


// 23. На вход программе подается строка текста. Напишите программу, которая
// определяет является ли строка хорошей. Текст хороший, если содержит
// подстроку «хорош» во всевозможных регистрах.
// я очень хороший текст => true

{
    System.Console.WriteLine(" введите любую строку");
    string? textUsera = Console.ReadLine();
    textUsera = textUsera.ToLower();
    Console.WriteLine(textUsera.Contains("хорош"));
}

// 24.На вход программе подается строка. Напишите программу, которая подсчитывает
// количество буквенных символов в нижнем регистре.
// abcABCD12345 => 3



// 25. На вход программе подается строка из букв А, Г, Ц, Т. Напишите программу,
// которая подсчитывает сколько букв
// АааГГЦЦцТТтттА => А – 4 Г – 2 Ц – 3 Т – 5 






// 26. На вход программе подается строка текста. Напишите программу, которая
// проверяет, что строка заканчивается подстрокой .com или .ru. Если
// заканчивается, то вывести true, в противном случае false
{
    System.Console.WriteLine(" введите сайт");
    string? textEmail = Console.ReadLine();
    if (textEmail.EndsWith(".com") || textEmail.EndsWith(".ru"))
    {
        System.Console.WriteLine(true);
    }
    else
    {
        System.Console.WriteLine(false);
    }
}

// 27. На вход подается url. Если он начинается с http, содержит хотя бы один “/” и
// заканчивается подстрокой .com или .ru, то вывести true, в противном случае false
{
    System.Console.WriteLine(" введите сайт");
    string? textEmail = Console.ReadLine();
    if (textEmail.StartsWith("http") && textEmail.Contains("/") && (textEmail.EndsWith(".com") || textEmail.EndsWith(".ru")))
    {
        System.Console.WriteLine(true);
    }
    else
    {
        System.Console.WriteLine(false);
    }
}
