using System;
using System.Collections.Generic;
using System.Text;

namespace CodeJamAlphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numberOfTestCases = Convert.ToByte(Console.ReadLine());
            for (byte x = 0; x < numberOfTestCases; x++)
            {
                int numberOfBlocks = Convert.ToInt32(Console.ReadLine());
                string numbersOfLettersInBlocks = Console.ReadLine();
                List<int> numberOfLettersInt = new List<int>();
                string[] numberOfLettersInBlock = numbersOfLettersInBlocks.Split(' ');

                foreach (string number in numberOfLettersInBlock)
                {
                    numberOfLettersInt.Add(Int32.Parse(number));
                }

                var validString = new StringBuilder();
                validString.Append('A');
                int currentAscii = 65;

                for (int i = 1; i <= numberOfBlocks; i++)
                {

                    if (i%2!=0)
                    {
                        for (int j = 0; j < numberOfLettersInt[]; j++)
                        {
                            int tmpAscii = currentAscii;
                            tmpAscii++;
                            validString.Append((char)tmpAscii);
                        }
                        currentAscii++;
                    }
                    else
                    {
                        for (int j = 0; j < numberOfLettersInt[]; j++)
                        {
                            int tmpAscii = currentAscii;
                            tmpAscii--;
                            validString.Append((char)tmpAscii);
                        }
                        currentAscii--;
                    }
                }

                Console.WriteLine("Case #{0}: {1}", x + 1, validString);

            }
        }
    }
}
