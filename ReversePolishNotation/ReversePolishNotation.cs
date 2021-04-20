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
using System.Collections.Generic;

namespace ReversePolishNotation
{
    class ReversePolishNotation
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack results = new Stack();
            double tmp;
            while (!String.IsNullOrWhiteSpace(input))
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (double.TryParse(input[i].ToString(), out tmp))
                    {
                        results.Push(tmp);
                    }
                    else
                    {
                        double first = (double)results.Pop();
                        double second = (double)results.Pop();
                        double newResult = UseInputOperator(input[i].ToString(), first, second);
                        results.Push(newResult);
                    }
                }
                foreach(var result in results)
                {
                    Console.Write(result);
                }
            }
        }
        public static double UseInputOperator(string logic, double x, double y)
        {
            return logic switch
            {
                "+" => x + y,
                "-" => x - y,
                "*" => x * y,
                "/" => x / y,
                _ => throw new Exception("invalid logic"),
            };
        }
    }
}
