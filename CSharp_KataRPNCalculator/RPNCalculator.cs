using System;
using System.Collections.Generic;
using System.Linq;

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

            var emptyStack = new Stack<int>();
            emptyStack = inputs.Aggregate(emptyStack, Apply);

            return emptyStack.Pop();

            int Add(int left, int right) => left + right;
            int Difference(int left, int right) => left - right;
            int Multiply(int left, int right) => left * right;
            int Divide(int left, int right) => left / right;

            Stack<int> DoOperation(Stack<int> stack, Func<int, int, int> operation)
            {
                var right = stack.Pop();
                var left = stack.Pop();
                stack.Push(operation(left, right));
                return stack;
            }

            Stack<int> Apply(Stack<int> stack, string token)
            {
                if (int.TryParse(token, out var value))
                {
                    stack.Push(value);
                    return stack;
                }

                switch (token)
                {
                    case "+": return DoOperation(stack, Add);
                    case "-": return DoOperation(stack, Difference);
                    case "/": return DoOperation(stack, Divide);
                    case "*": return DoOperation(stack, Multiply);
                }

                return stack;
            }
        }
    }
}
