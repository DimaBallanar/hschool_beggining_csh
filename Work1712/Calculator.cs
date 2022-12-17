namespace TaskHard // Note: actual namespace depends on the project name.
{
    public class Calculate
    {
        public double Result;

        public Calculate()
        {

        }
        public Calculate(double n)
        {
            Result = n;

        }
        public double Summ(double n)
        {
            Result += n;
            return Result;
        }
        public double Defination(double n)
        {
            Result -= n;
            return Result;
        }
        public double Multiplication(double n)
        {
            Result *= n;
            return Result;
        }
        public double Division(double n)
        {
            Result /= n;
            return Result;
        }

    }
}