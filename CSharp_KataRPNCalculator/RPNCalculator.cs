using System;
using System.Collections.Generic;

namespace CSharp_KataRPNCalculator
{
    public static class RpnCalculator
    {
        public static int Calculate(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            return int.Parse(input);
        }
    }
}
