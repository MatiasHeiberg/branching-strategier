namespace branching_strategi
{
    public class Math
    {
        public int Multiplication(int a, int b)
        { return a * b; }

        public double SquareRoot(double a)
        {
            return System.Math.Sqrt(a);
        }
        public int power_nth(int @base, int exponent)
        {
            int result = @base;
            for (int i = 1; i < exponent; i++)
            {
                result *= @base;
            }
            return result;
        }


        public double divide(double a, double b)
        {
            double result = a / b;
            return result;

        }

        public double Average(List<int> tal)
        {
            return tal.Average();
        }

        public double Mudolo(double a, double b)
        {
            double result = a % b;
            return result;
        }


    }
}
