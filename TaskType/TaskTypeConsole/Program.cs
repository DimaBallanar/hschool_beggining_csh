﻿// 1) Даны переменные a = 10 и b = 3. Найдите остаток от деления a на b.
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


