/*
Evaluate an expression in Reverse Polish Notation (otherwise known as Postfix notation).
Assume there are 4 numerical operators: + - * /, and numbers can be floating point values.
Each token in the expression, be it a number of operator, is separated from its neighbours by one or more spaces, to make the expression easy to parse.
The program should read a series of input strings from stdin and output either the evaluated number to 4 decimal places (use the %.4f print format), or the single word "ERROR".
If the expression is not parseable, does not evaluate correctly, or leaves extra data on the stack, the output should be "ERROR".
An example INPUT/OUTPUT sequence is given below for reference.

Input
A series of RPN expressions, one per line on stdin.

Output
One line for each output element - either the numerical output, or the string "ERROR"*/


using System;
using System.Collections;

namespace ReversePolishNotation
{
    class ReversePolishNotation
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack results = new Stack();
            do
            {
                string[] inputArray = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                float result;
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (float.TryParse(inputArray[i], out result))
                    {
                        results.Push(result);
                    }
                    else
                    {
                        if (results.Count < 2)
                        {
                            results.Clear();
                            break;
                        }
                        else
                        {
                            float second = (float)results.Pop();
                            float first = (float)results.Pop();
                            float newResult = UseInputOperator(inputArray[i], first, second);
                            results.Push(newResult);
                        }
                    }
                }

                if (results.Count != 1) Console.WriteLine("ERROR");
                else
                {
                    double finalResult = Math.Round((float)results.Pop(), 4);
                    Console.WriteLine(finalResult);
                }
                input = Console.ReadLine();
            } 

            while (!string.IsNullOrEmpty(input));
        }
        public static float UseInputOperator(string logic, float x, float y)
        {
            switch (logic)
            {
                case "+": return x + y;
                case "-": return x - y;
                case "*": return x * y;
                case "/": return x / y;
                default: throw new Exception("invalid logic");
            }
        }
    }
}
