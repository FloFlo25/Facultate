using System;
using System.IO;

namespace _2021__EXP_MAP_Floruta_Raul_03_
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"..\..\..\data04.in");
            //Read the first line of text
            string line = sr.ReadLine();
            File.WriteAllText(@"..\..\..\data04.out", CalculateResultFromRPN(line).ToString());
        }

        private static double CalculateResultFromRPN(string reversePolishNotation)
        {
            reversePolishNotation = reversePolishNotation.Trim();
            string[] split = reversePolishNotation.Split();
            Stack<string> stack = new Stack<string>();

            foreach (var item in split)
            {
                if (IsOperator(item[0]))
                {
                    double num2 = double.Parse(stack.Pop());
                    double num1 = double.Parse(stack.Pop());
                    double result = GetOperationResult(num1, item, num2);
                    stack.Push(result.ToString());
                }
                else
                {
                    stack.Push(item);
                }
            }
            return double.Parse(stack.Pop());
        }

        private static double GetOperationResult(double num1, string op, double num2)
        {
            switch (op)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    return num1 / num2;
                default:
                    throw new InvalidOperationException();
            }
        }

        private static bool IsOperator(char c)
        {
            switch (c)
            {
                case '+':
                case '-':
                case '*':
                case '/':
                case '(':
                case ')':
                    return true;
            }
            return false;
        }
    }
}
