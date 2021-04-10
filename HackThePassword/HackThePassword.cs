using System;
using System.Collections.Generic;
using System.Text;

namespace HackThePassword
{
    class HackThePassword
    {
        static void Main(string[] args)
        {
            byte numberOfTestCases = Convert.ToByte(Console.ReadLine());
            for (byte i = 0; i < numberOfTestCases; i++)
            {
                string input = Console.ReadLine();
                List<char> leftResults = new List<char>();
                List<char> rightResults = new List<char>();
                var finalResult = new StringBuilder();

                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == '<')
                    {
                        if (leftResults.Count > 0)
                        {
                            char tmp = leftResults[leftResults.Count - 1];
                            rightResults.Add(tmp);
                            leftResults.RemoveAt(leftResults.Count - 1);
                        }
                    }

                    else if (input[j] == '>')
                    {
                        if (rightResults.Count > 0)
                        {
                            char tmp = rightResults[rightResults.Count - 1];
                            leftResults.Add(tmp);
                            rightResults.RemoveAt(rightResults.Count - 1);
                        }
                    }

                    else if (input[j] == '-')
                    {
                        if (leftResults.Count > 0)
                        {
                            leftResults.RemoveAt(leftResults.Count - 1);
                        }
                    }

                    else
                    {
                        leftResults.Add(input[j]);
                    }
                }

                rightResults.Reverse();
                leftResults.AddRange(rightResults);
                finalResult.Append(leftResults.ToArray());

                Console.WriteLine(finalResult);
            }
        }
    }
}
