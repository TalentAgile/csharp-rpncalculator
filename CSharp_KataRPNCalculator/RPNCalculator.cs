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

            var inputs = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (inputs.Length > 1)
            {
                switch (inputs[2])
                {
                    case "+":
                        return int.Parse(inputs[0]) + int.Parse(inputs[1]);
                    case "-":
                        return int.Parse(inputs[0]) - int.Parse(inputs[1]);
                }
            }

            return int.Parse(input);
        }
    }
}
