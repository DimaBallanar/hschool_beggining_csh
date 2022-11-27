// using System;

// namespace MyApp // Note: actual namespace depends on the project name.
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             string firstName = "Emilia";
//             string lastName = "Clarke";
//             Console.WriteLine(CreateUser("Emilia", age: 36, lastName: lastName, height: 156, weight: 77));
//         }

//         static string CreateUser(string firstName, string lastName, int age, int height, double weight)
//         {
//             return $"{firstName},{lastName},{age},{height},{weight}";
//         }

//     }
// }
static double CalculateCost(double costItem, double vat = 13, double costumDuty = 5, double Tax = 10)
{
    vat = 1 + vat / 100;
    costumDuty = 1 + costumDuty / 100;
    Tax = 1 + Tax / 100;
    return costItem * vat * costumDuty * Tax;
}
System.Console.WriteLine(CalculateCost(100, costumDuty: 7));