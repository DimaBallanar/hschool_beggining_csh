
void Counter(ref int value)
{
    value++;
    System.Console.WriteLine(value);
}

int value=0;
Counter(ref value);
System.Console.WriteLine(value);
Counter(ref value);
System.Console.WriteLine(value);

internal class Program
{
    static bool Parse(string text, char separator, out string name, out string age)
    {
        string[] result = text.Split(separator);
        if (result.Length == 2)
        {
            name = result[0];
            age = result[1];
            return true;
        }

        name = "";
        age = "";
        return false;
    }

    static void Main()
    {
        Parse("text_21", '_', out string name, out string age);
        System.Console.WriteLine("name - {0} age = {1}", name, age);
    }
}
