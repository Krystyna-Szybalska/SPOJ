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
                string inputString = Console.ReadLine();
                List<char> leftResults = new List<char>();
                List<char> rightResults = new List<char>();
                var finalResult = new StringBuilder();

                for (int j = 0; j < inputString.Length; j++)
                {
                    if (inputString[j] == '<')
                    {
                        if (leftResults.Count > 0)
                        {
                            char tmp = leftResults[leftResults.Count - 1];
                            rightResults.Add(tmp);
                            leftResults.RemoveAt(leftResults.Count - 1);
                            continue;
                        }
                        continue;
                    }

                    else if (inputString[j] == '>')
                    {
                        if (rightResults.Count > 0)
                        {
                            char tmp = rightResults[rightResults.Count - 1];
                            leftResults.Add(tmp);
                            rightResults.RemoveAt(rightResults.Count - 1);
                            continue;
                        }
                        continue;
                    }

                    else if (inputString[j] == '-')
                    {
                        if (leftResults.Count > 0)
                        {
                            leftResults.RemoveAt(leftResults.Count - 1);
                            continue;
                        }
                        continue;
                    }

                    else
                    {
                        leftResults.Add(inputString[j]);
                        continue;
                    }
                }

                rightResults.Reverse();
                leftResults.AddRange(rightResults);

                foreach (char result in leftResults)
                {
                    finalResult.Append(result.ToString());
                }

                Console.WriteLine(finalResult);
            }
        }
    }
}
