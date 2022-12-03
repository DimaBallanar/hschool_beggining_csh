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

static int IndexSearch(int[] userMassiv)
{
    for (int p = 0; p<userMassiv.Length; p++)
    {
        int num = 0;
        for (int i = 0; i < userMassiv.Length; i++)
        {
            if(userMassiv[i]==userMassiv[userMassiv.Length-1])
{
System.Console.WriteLine();
}
        }
    }
    


}
// int i = 1;
// Console.WriteLine(string.Format("i = {0}", --i));

// double number = Convert.ToDouble(Console.ReadLine());
// if (number = 2.54) 
// {
//   Console.WriteLine(number + 1,13 + 10.50);
// }
// else 
// {
//     var result = number * 15;
//     Console.WriteLine(result);
// }