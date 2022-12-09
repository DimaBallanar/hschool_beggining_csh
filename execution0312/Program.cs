// // Как изменить порядок элементов в строке на обратный без использования вспомогательных классов и методов?
// string text="qwerty";
// string user="";
// for(int i=text.Length-1;i>=0;i--)
// {
//     user+=text[i];
// }
// System.Console.WriteLine(user);



// Как определить позиции дублированного элемента и его значение в массиве, в котором содержа
// тся все элементы типа int от 1 до 100, при этом в массиве только один элемент дублируется?

// (массив не надо заполняит значениями, массив со значениями уже объялен и передается в метод)

// static int IndexSearch(int[] userMassiv)
// {
//     for (int p = 0; p<userMassiv.Length; p++)
//     {
//         int num = 0;
//         for (int i = 0; i < userMassiv.Length; i++)
//         {
//             if(userMassiv[i]==userMassiv[userMassiv.Length-1])
// {
// System.Console.WriteLine();
// }
//         }
//     }



// }
// int i = 1;
// Console.WriteLine(string.Format("i = {0}", --i));


// double number = Convert.ToDouble(Console.ReadLine());
// if (number == 2.54) 
// {
//   Console.WriteLine(number + 1.13 + 10.50);
// }
// else 
// {
//     var result = number * 15;
//     Console.WriteLine(result);
// }
//==============================================================================================================================================
// System.Console.WriteLine(CustomFormat("fgr {0},{1}", true, 'f'));
//   // System.Console.WriteLine($"{{{0}}}");



// string CustomFormat(string format, params object[] items)
// {
//     for (int i = 0; i < items.Length; i++)
//     {
//         //"{i}" => items[i] 
//         //{0} => 6
//         //{1} => "ffd"
//         format = format.Replace($"{{{i}}}", items[i].ToString());  //доработать кастом формат,дописать проверки
//     }

//     return format;
// }
//====================================================================================================================================================
// int a=1;
// object box=a;
// string text111=box.ToString();
// int b=5;
// int c=23421441;
// System.Console.WriteLine($"{a},{b},{c}");
// System.Console.WriteLine(text111);

// 3. Написать метод, который удаляет из строки заданный символ. Символ является входным параметром-значением. Строка должна быть параметром-ссылкой и результатом. (ref)


//     System.Console.WriteLine("Введите символ, который хотите удалить");
//     char simbol = Convert.ToChar(Console.ReadLine());
//     // char simbol='z';
//     string text = "";
//     if (!string.IsNullOrEmpty(Convert.ToString(simbol)))
//     {
//         System.Console.WriteLine(MethodDelete(simbol, ref text));
//     }

// static string MethodDelete(char simbol, ref string text)
// {
//     text = "Тzыz zклаzсzсzнzыzйz zиz zуz zтzеzбzя zвсzеz zпоzлzуzчzиzтzсяz,z zхzорzоzшzеzгоz zдzнzя";
//     string result = "";
//     for (int i = 0; i < text.Length; i++)
//     {
//         if (text[i] != simbol)
//         {
//             result += text[i];
//         }
//     }
//     text=result;
//     return text;
// }



// string? text = Console.ReadLine();
// string? symbol = Console.ReadLine();
// if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(symbol))
// {
//     Console.WriteLine(MethodAllSearch(text, symbol));
// }
// else
// {
//     Console.WriteLine("error");
// }


// static (string, int, int, int) MethodAllSearch(string text, string symbol)
// {
//     int count = 0;
//     int indexFirst = -1;
//     int indexLast = -1;
//     int LengthSymbol = symbol.Length;
//     for (int i = 0; i <= text.Length - LengthSymbol; i++)
//     {
//         string temp = "";
//         for (int j = i; j <= i + (LengthSymbol - 1); j++)
//         {
//             temp += text[j];
//         }
//         if (temp == symbol)
//         {
//             if (indexFirst == -1)
//             {
//                 indexFirst = i;
//             }
//             indexLast = i;
//             count++;
//         }
//     }
//     return (symbol, count, indexFirst, indexLast);
// }
//indexStart=4, indexEnd=4, [x,x,x,x,55,...], 44
// int BinarySearchIndex(int[] userArray, int numSearch, int indexStart, int indexEnd)
// {

//     if (indexStart > indexEnd)
//     {
//         return -1;
//     }
//     int middleIndex = (indexEnd + indexStart) / 2;
//     return numSearch == userArray[middleIndex] ? middleIndex :
//      numSearch > userArray[middleIndex] ?
//     BinarySearchIndex(userArray, numSearch, middleIndex + 1, indexEnd) :
//     BinarySearchIndex(userArray, numSearch, indexStart, middleIndex - 1);

// }

// // [0,4] 5 ищем
// int[] userMassiv = { 1, 4, 5, 7, 8, 9, 22, 23, 25, 33, 39, 44, 46, 55, 88, 99 };
// // int[] userMassiv = { 0, 4 };
// int number = Convert.ToInt32(Console.ReadLine());
// int index = BinarySearchIndex(userMassiv, number, 0, userMassiv.Length - 1);
// System.Console.WriteLine(index);

// System.Console.WriteLine(element);

// Console.WriteLine("Нажмите любую клавишу, а затем Enter");
// int key1 = Console.Read();
// Console.WriteLine($"Код нажатой клавиши: {key1}");
// Console.WriteLine("Символьное представление: " + Convert.ToChar(key1));



int x = 1234;
char[] mas=x.ToString().ToCharArray();
System.Console.WriteLine(string.Join(",",mas));
// for (int i = 0; i < Convert.ToString(x).Length; i++)
// {
//     if (Convert.ToString(x)[i] % 2 == 0)
//     {
//         System.Console.WriteLine(x.ToString()[i]);
//         System.Console.WriteLine("четное");
//     }
//     else
//     {
//         System.Console.WriteLine("нечетное");
//     }
// }

// foreach (int h in Convert.ToString(x))
// {
//     string message = h % 2 == 0 ? "четное" : "нечетное";
//     System.Console.WriteLine(message);
// }
// string y="1";
// System.Console.WriteLine(y);
// System.Console.WriteLine(Convert.ToInt32(y));




