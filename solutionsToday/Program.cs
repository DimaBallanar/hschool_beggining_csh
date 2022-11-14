// int number = 5;
// object item = number;
// System.Console.WriteLine(item.GetType());
// string text = "text";
// item = text;
// System.Console.WriteLine(item.GetType());
// char symbol = '?';
// item = symbol;
// System.Console.WriteLine(item.GetType());
// bool value = true;
// item = value;
// System.Console.WriteLine(item.GetType());

// object item1 = 5.0;
// //подходит если вы уверены на 100%, что item это число
// double number1 = Convert.ToDouble(item1); 
// object item2 = 4;
// //происходит проверка на тип данных, если к такому типу данных привести 
// //возможно возвращаем число, в противном случае значение по умолчанию
// int number2 = item2 is int number ? number : default;

// два числа с моего ввода, 2 обджжекта ,если 2 стринги то возвращаем сумму их длин, 2 инта -сумму интов, в противном ничего не ввести

// object myItem1 = 64;
// object stasItem = "daroy otec";
// if (myItem1 is string string1 && stasItem is string string2)
// {
//     System.Console.WriteLine(string1.Length + string2.Length);
// }
// else if (myItem1 is int int1 && stasItem is int int2)
// {
//     System.Console.WriteLine(int1 + int2);
// }
// else
// {
//     System.Console.WriteLine("empty");
// }

// var random = new Random();

// int result=random.Next(3, 4);
// System.Console.WriteLine(result);


// int number = 5;

// System.Console.WriteLine(number.ToString().GetType());

// bool value = true;

// System.Console.WriteLine(value.ToString().GetType());



// string userText="\\\"";
// System.Console.WriteLine(userText);

// string text1 = null;
// //равнозначно
// string? text2 = null;

// у нас есть строка,где для всех букв произвести следующие операции, 
// если код этой буквы равен простому числу-то суммируем если нет -игнорируем
System.Console.WriteLine("введите строку");
string? userText = Console.ReadLine();
if (!string.IsNullOrEmpty(userText))
{
    int result = 0;
    foreach (char let in userText)
    {
        if (!char.IsLetter(let))
        {
            continue;
        }
        int number = +let;
        // int number = Convert.ToInt32(let);
        bool isSimpleNumber = true;
        for (int i = 2; i <= number / 2; i++)
        {
            if (number % i == 0)
            {
                isSimpleNumber = false;
                break;
            }
        }
        if (isSimpleNumber)
        {
            // прибавляем с результату значение
            result += number;
        }
    }
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("Null");
}


// 2 ваиант кода
// int number = +let;
//         // int number = Convert.ToInt32(let);
//         bool isSimpleNumber = true;
//         for (int i = 2; i <= number / 2 && isSimpleNumber; i++)
//         {
//             isSimpleNumber = number % i == 0;
//         }








