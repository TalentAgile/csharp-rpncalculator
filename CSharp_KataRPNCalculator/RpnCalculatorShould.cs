using NFluent;
using NUnit.Framework;

namespace CSharp_KataRPNCalculator
{
    internal class RpnCalculatorShould
    {
        [Test]
        public void Return_zero_when_input_is_an_empty_string()
        {
            var result = RpnCalculator.Calculate("");
            Check.That(result).IsZero();
        }

        [TestCase("1", 1)]
        [TestCase("4", 4)]
        public void Return_number_when_input_is_a_single_number(string input, int expected)
        {
            var result = RpnCalculator.Calculate(input);
            Check.That(result).IsEqualTo(expected);
        }

        [TestCase("1 1 +", 2)]
        [TestCase("6 3 +", 9)]
        public void Return_sum_of_numbers_when_input_contains_two_numbers_and_plus_sign(string input, int expected)
        {
            var result = RpnCalculator.Calculate(input);
            Check.That(result).IsEqualTo(expected);
        }

        [TestCase("1 1 -", 0)]
        [TestCase("7 3 -", 4)]
        public void Return_difference_between_numbers_when_input_contains_two_numbers_and_minus_sign(string input, int expected)
        {
            var result = RpnCalculator.Calculate(input);
            Check.That(result).IsEqualTo(expected);
        }

        [TestCase("1 2 *", 2)]
        [TestCase("7 3 *", 21)]
        public void Return_product_of_numbers_when_input_contains_two_numbers_and_multiplication_sign(string input, int expected)
        {
            var result = RpnCalculator.Calculate(input);
            Check.That(result).IsEqualTo(expected);
        }

        [TestCase("1 1 /", 1)]
        [TestCase("9 3 /", 3)]
        public void Return_quotient_of_numbers_when_input_contains_two_numbers_and_division_sign(string input, int expected)
        {
            var result = RpnCalculator.Calculate(input);
            Check.That(result).IsEqualTo(expected);
        }

        [TestCase("1 2 + 3 *", 9)]
        [TestCase("16 4 - 1 1 + /", 6)]
        [Ignore("Remove to enable the test")]
        public void Return_retsult_of_multiple_operations_when_input_contains_multiple_operations(string input, int expected)
        {
            var result = RpnCalculator.Calculate(input);
            Check.That(result).IsEqualTo(expected);
        }
    }
}
