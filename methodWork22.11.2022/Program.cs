
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

internal class Program1
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

internal class Program2
{
    static double CustomNumberConverter(string textNumber, char separator = ',')
    {
        if (string.IsNullOrEmpty(textNumber))
        {
            return 0;
        }
        textNumber = textNumber.Replace(separator.ToString(), "");
        return double.TryParse(textNumber, out double number) ? number : default;
    }

    static void Main()
    {
        //33.233.345.334,23;
        //33,235,345,334.23;
        System.Console.WriteLine(CustomNumberConverter("33,235,345,334.23"));
        System.Console.WriteLine(CustomNumberConverter("33.233.345.334,23", '.'));
    }
}