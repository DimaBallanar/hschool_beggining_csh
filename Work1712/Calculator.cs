namespace TaskHard // Note: actual namespace depends on the project name.
{
    public class Calculate
    {
        private double Result;

        public Calculate()
        {

        }
        public Calculate(double number)
        {
            Result = number;

        }
        private double Summ(double number)
        {
            // double Test=Result=number=10;   
            Console.Write($"{Result} + {number} = ");
            Result += number;
            System.Console.WriteLine(Result);
            // System.Console.WriteLine($"{Result} + {number} = {Result += number}");
            return Result;
        }
        private double Defination(double number)
        {
            Console.Write($"{Result} - {number} = ");
            Result -= number;
            System.Console.WriteLine(Result);
            return Result;
        }
        private double Multiplication(double number)
        {
            Console.Write($"{Result} * {number} = ");
            Result *= number;
            System.Console.WriteLine(Result);
            return Result;
        }
        private double Division(double number)
        {
            Console.Write($"{Result} / {number} = ");
            Result /= number;
            System.Console.WriteLine(Result);
            return Result;
        }
        public double Search(string symbol, double number)
        {
            // if (symbol == "+")
            // {
            //     return Summ(number);
            // }
            // if (symbol == "-")
            // {
            //     return Defination(number);
            // }
            // if (symbol == "*")
            // {
            //     return Multiplication(number);
            // }
            // if (symbol == "/")
            // {
            //     return Division(number);
            // }
            // return Result;


            // switch (symbol)
            // {
            //     case "+": return Summ(number);
            //     case "-": return Defination(number);
            //     case "*": return Multiplication(number);
            //     case "/": return Division(number);
            //     default: return Result;
            // }

            return symbol switch
            {
                "+" => Summ(number),
                "-" => Defination(number),
                "*" => Multiplication(number),
                "/" when number != 0 => Division(number),
                _ => Result
            };

        }

    }
}