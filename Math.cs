using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
