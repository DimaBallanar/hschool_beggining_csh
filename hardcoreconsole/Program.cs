var value = 5;

string? message = null;

if (value == 4)
{
    message = "Test";
}

System.Console.WriteLine(message ?? "Default Text");