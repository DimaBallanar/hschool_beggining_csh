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
// else { System.Console.WriteLine("вы ввели не строку"); }
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
// char[]result=textUser.ToCharArray();
// Console.WriteLine(result.Length);
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