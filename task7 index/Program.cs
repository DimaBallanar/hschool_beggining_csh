// 1. Ввести строку. Если эта равна “hschool”, вывести true. В противном случае false.
// Добавить проверки для строк. Удалить лишние пробелы


// string? textEnter = Console.ReadLine();

// if (!string.IsNullOrEmpty(textEnter))
// {
//     if (textEnter.ToLower().Trim() == "hschool")
//     {
//         // bool result= textEnter.ToLower().Trim() == "hschool";
//         System.Console.WriteLine(textEnter.ToLower().Trim() == "hschool");
//     }
//     else
//     {
//         System.Console.WriteLine(false);
//     }
// }
// else
// {
//     System.Console.WriteLine("вы ввели не строку");
// }


// 2. Ввести строку. Проверить является ли это число или строка. Если число, то
// выяснить, четное или нет. Если это строка то преобразовать строку в массив, где
// каждый символ – один элемент массива
// ‘hschool’ => [‘h’, ‘s’, ‘c’, ‘h’, ‘o’, ‘o’, ‘l’]
// System.Console.WriteLine("введите строку");
// String? textUser = Console.ReadLine();
// if (!string.IsNullOrEmpty(textUser))
// {
//     if (double.TryParse(textUser, out double number))
//     {
//         Console.WriteLine(number % 2 == 0 ? "четное число" : "не четное число");
//     }
//     else
//     {
//         char[] result = textUser.ToCharArray();
//         Console.WriteLine(result.Length);
//     }
// }


// 3. Преобразовать строку ‘Full сStaCK DevELoper’ в массив вида [‘full, ‘stack’,
// ‘developer’]

// string textUser = "Full сStaCK DevELoper";
// textUser = textUser.ToLower();
// string[] result = textUser.Split(' ');
// System.Console.WriteLine(result[0]);
// System.Console.WriteLine(result[1]);
// System.Console.WriteLine(result[2]);


// 4. Ввести строку. Проверить на isNaN. Если число, то ошибка ввода. Если это строка
// то узнать какая у нее длина. Привести к одному регистру, убрать лишние пробелы
// System.Console.WriteLine("введите строку");
// string? userText = Console.ReadLine();
// if (!string.IsNullOrEmpty(userText))
// {
//     if (int.TryParse(userText, out int number))
//     {
//         System.Console.WriteLine("ошибка ввода");
//     }
//     else
//     {
//         System.Console.WriteLine($"символов в строке: {userText.Length}");
//         System.Console.WriteLine(userText.ToLower());
//         System.Console.WriteLine(string.Join(" ", userText.Split(' ', StringSplitOptions.RemoveEmptyEntries)));   //// вопросики,еще раз обьяснить как работает это комбо команд
//     }
// }

// 5. ‘HTML JavaScript PHP’ преобразовать в "HTML-JAVASCRIPT-PHP"

// string userStas="HTML JavaScript PHP";
// userStas=userStas.ToUpper();
// System.Console.WriteLine(userStas.Replace(" ", "-"));


// 6. Ввести строку. Проверить является ли это число или строка. Если число, то ошибка ввода. Если это строка то первый символ поставить в верхний регистр.
// Убрать лишние пробелы

// System.Console.WriteLine("введите свою строку");
// string? inputText = Console.ReadLine();
// if (!string.IsNullOrEmpty(inputText))
// {
//     if (int.TryParse(inputText, out int numberText))
//     {
//         System.Console.WriteLine("ошибка ввода");
//     }
//     else
//     {
//         string? liter = Convert.ToString(inputText[0]);
//         liter = liter.ToUpper();
//         inputText = liter + inputText.Remove(0, 1);
//         System.Console.WriteLine(string.Join(" ", inputText.Split(' ', StringSplitOptions.RemoveEmptyEntries)));
//     }
// }

// 7. На вход программе подаётся строка. Замените все @ на '!' с помощью
// глобального поиска и замены (2 способа)

// 1 способ
// {
// System.Console.WriteLine("введите строку");
// string? inputMessage = Console.ReadLine();
// if (!string.IsNullOrEmpty(inputMessage))
// {
//     Console.WriteLine(inputMessage.Replace('@', '!'));
// }
// else
// {
// System.Console.WriteLine("null");
// }
// }
// // 2 способ
// {
//     System.Console.WriteLine("введите строку");
// string? inputMessage = Console.ReadLine();
// if (!string.IsNullOrEmpty(inputMessage))
// }



//8. Дана строка 'aaa bbb ccc'. Вырежите из нее слово 'bbb'

string Text= "aaa bbb ccc";
System.Console.WriteLine(Text.Remove(4, 4));
