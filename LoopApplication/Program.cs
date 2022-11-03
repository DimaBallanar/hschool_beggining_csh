// // 1 1. Выведите столбец чисел от 1 до 50. for, while
// {
//     int chislo = 0;
//     for (int i = 1; i <= 50; i++)
//     {

//     }
// }

// 2. [1, 2, 3, 4, 5]. Выведите каждый элемент массива 3 любыми циклами
{
    System.Console.WriteLine("for");
    int[] massiv = new int[] { 1, 2, 3, 4, 5 };
    for (int i = 0; i < massiv.Length; i++)
    {
        System.Console.WriteLine(massiv[i]);
    }

    System.Console.WriteLine("while");
    int index = 0;
    while (index < 5)
    {
        System.Console.WriteLine(massiv[index]);
        index++;
    }
    System.Console.WriteLine("foreach");
    foreach (int count in massiv)
    {
        System.Console.WriteLine(count);
    }
}
// 3. Дан массив с элементами [2, 3, 4, 5]. С помощью 3 циклов найдите произведение
// элементов этого массива.
{
    System.Console.WriteLine("for");
    int[] massiv = new int[] { 2, 3, 4, 5 };
    int umnFor = 1;
    for (int i = 0; i < massiv.Length; i++)
    {
        umnFor = umnFor * massiv[i];
    }
    System.Console.WriteLine(umnFor);

    System.Console.WriteLine("while");
    int index = 0;
    int umnWhile = 1;
    while (index < 4)
    {
        umnWhile = umnWhile * massiv[index];
        index++;
    }
    System.Console.WriteLine(umnWhile);
    System.Console.WriteLine("foreach");
    int umnForeEach = 1;
    foreach (int count in massiv)
    {
        umnForeEach = umnForeEach * massiv[count - 2];
    }
    System.Console.WriteLine(umnForeEach);
}

// 4. Выведите столбец чисел от 11 до 33 циклом while
{
    int i = 11;
    while (i <= 33)
    {
        System.Console.WriteLine(i++);
    }
}
// 5.