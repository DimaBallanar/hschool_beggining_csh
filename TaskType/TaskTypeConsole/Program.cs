// 1) Даны переменные a = 10 и b = 3. Найдите остаток от деления a на b.
int a = 10;
int b = 3;
int c = a%b;
Console.WriteLine($"Остаток от деления 10 на 3 равен {c}");
//Пользователь вводит с клавиатуры 2 числа: основание степени и показатель степени. Необходимо возвести число во введенную степень
Console.WriteLine("Введите число: ");
int d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("В какую степень его возвести?");
int f = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($" мой ответ " + Math.Pow(d,f)); // используем оператор Math.Pow для возведения числа в заданную степень
// Напишите программу, которая считывает длины двух катетов в прямоугольном треугольнике и выводит его площадь. Используйте формулу: s=1/2*a*b
Console.WriteLine("напишите длинну первого катета");
int katet1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("напишите длинну второго катета");
int katet2 = Convert.ToInt32(Console.ReadLine());
double s = 0.5*katet1*katet2;  // использовал double потому что используем дробное значение 0,5
Console.WriteLine($"если это прямогульный треугольник,то его площадь равна  {s}");
//Напишите скрипт, который определяет, какой температуре по шкале Цельсия соответствует указанное значение по шкале Фаренгейта 451
short F = 451;
int celsiy = (F- 32) / 9 * 5;
Console.WriteLine($"451 по Фаренгейту - это {celsiy} по Цельсию");
// Даны переменные a и b. Проверьте, что a делится без остатка на b. Если это так -выведите 'Делится' и результат деления, иначе выведите 'Делится с остатком' и,само значение деления
Console.WriteLine("Введите первое число : ");
int pervoe = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число : ");
int vtoroe = Convert.ToInt32(Console.ReadLine());
int ostatok = pervoe%vtoroe;
int ostatok1 = pervoe/vtoroe;
if(ostatok > 0)
{
    Console.WriteLine($"Делится с остатком  {ostatok}");
}
else
{
    Console.WriteLine($"Делится  {ostatok1}");
}
//Вы вводите 2 числа a и b. Вам необходимо решить пример (2(а-b)-4(b-a))/2
Console.WriteLine("Введите число 1: ");
int a6 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int b6 = Convert.ToInt32(Console.ReadLine());
int primer6 = (2*(a6-b6)-4*(b6-a6))/2;
Console.WriteLine($"{primer6}");
// На вход программе подается число n – количество собачьих лет. Напишите
// программу, которая вычисляет возраст собаки в человеческих годах.
// В течение первых двух лет собачий год равен 10.5 человеческим годам. После
// этого каждый год собаки равен 4 человеческим годам
Console.WriteLine("Давайте посчитаем сколько лет вашей собаке");
int n = Convert.ToInt32(Console.ReadLine());
if(n<=2) // если собаке год или 2,то по формуле возраст на 10,5
{
   double melkaya = n*10.5;
   Console.WriteLine($"{melkaya}");
}
else    // в ином случае  первые два года по 10,5 а дальше каждый +4
{
    Console.WriteLine($"{2*10.5+(n-2)*4}");
}
//Найдите квадратный корень из 245
double koren = Math.Sqrt(245);
Console.WriteLine($"квадратный корень с 245 равен {koren}");
//Даны числа 4, -2, 5, 19, -130, 0, 10. Найти максимальное и минимальное число с помощью Math.Min и Math.Max
int a9 = 4;
int b9 = -2;
int c9 = 5;
int d9 = 19;
int e9 = -130;
int f9 = 0;
int g9 = 10;
double max = Math.Max(a9,Math.Max(b9,Math.Max(c9,Math.Max(d9,Math.Max(e9,Math.Max(f9,g9)))))); // Math.Max() помогает выбрать с 2 знанчений большее
Console.WriteLine($"с нашего перечня чисел максимальноe - {max}");
double min = Math.Min(a9,Math.Min(b9,Math.Min(c9,Math.Min(d9,Math.Min(e9,Math.Min(f9,g9))))));  // Math.Min() помогает выбрать с 2 значений меньшее
Console.WriteLine($"с нашего перечня чисел минимальное - {min}");
//Написать программу ,которая вычисляет обьем куба и площаль поверхности ,зная длину ребра
Console.WriteLine("введи длину ребра куба");
int rebroKuba = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Объём куба будет равен {Math.Pow(rebroKuba,3)}");
Console.WriteLine($"Площадь его полной поверхности будет равна {6*Math.Pow(rebroKuba,2)}");
// Напишите программу, в которой вычисляется сумма, разность, произведение двух целых чисел,которые введут с клавиатуры
Console.WriteLine("Введите первое число");
int a11 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b11 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"сумма этих двух чисел будет равна {a11+b11}");
Console.WriteLine($"разность этих двух чисел будет равна {a11-b11}");
Console.WriteLine($"произведение этих двух чисел будет равно {a11*b11}");
// написать программу для пересчета временных интервалов ,заданных в минутах , в величину,выраженную в часах и минутах
