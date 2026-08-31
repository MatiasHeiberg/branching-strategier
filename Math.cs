using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace branching_strategi
{
    public class Math
    {
        public int power_nth (int @base, int exponent)
        {
            int result = @base;
            for (int i = 1;  i < exponent; i++)
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
