using System;
using System.Collections.Generic;

namespace CodeJam2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numberOfTestCases = Convert.ToByte(Console.ReadLine());
            char player = 'I';
            for (byte x = 0; x < numberOfTestCases; x++)
            {
                int score = 1;
                string B = Console.ReadLine();
                List<char> input = new List<char>();
                foreach(char letter in B)
                {
                    input.Add(letter);
                }

                if (player == 'I')
                {
                    if(input[0] == 'O' && input[input.Count-1] == 'O')
                    {
                        player = 'O';
                        score += input.Count;
                    }

                    else if(input[0] == 'I')
                    {
                        input.RemoveAt(0);
                        player = 'O';
                    }

                    else if (input[input.Count - 1] == 'I')
                    {
                        input.RemoveAt(input.Count - 1);
                        player = 'O';
                    }
                }

                if (player == 'O')
                {
                    if (input[0] == 'I' && input[input.Count - 1] == 'I')
                    {
                        player = 'I';
                        score += input.Count;
                    }

                    else if (input[0] == 'O')
                    {
                        input.RemoveAt(0);
                        player = 'I';
                    }

                    else if (input[input.Count - 1] == 'O')
                    {
                        input.RemoveAt(input.Count - 1);
                        player = 'I';
                    }
                }


                Console.WriteLine("Case #{0}: {1}, {2}", x + 1, player), score);
            }
    }
}
