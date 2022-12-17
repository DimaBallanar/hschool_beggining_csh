

using OOPday1.MyClasses;

namespace OOPday1
{
    internal class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            CustomArray arrayObj = new CustomArray(5);
            arrayObj.InicializationArray();
            arrayObj.Print();
            arrayObj.AddItem(random.Next(-100, 100), random.Next(-5, 5));
            arrayObj.Print();
            arrayObj.AddItem(random.Next(-100, 100));
            arrayObj.Print();
            arrayObj.AddItem(random.Next(-100, 100), random.Next(-100, 100), random.Next(-100, 100));
            arrayObj.Print();
            CustomArray.Information();

            // дописать метод сумма и метод разность массивов
        }
    }
}