using System;
using System.Collections.Generic;

namespace SPOJ
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numberOfTestCases = Convert.ToByte(Console.ReadLine());
            for (byte x = 0; x < numberOfTestCases; x++)
            {
                List<int> sizesList = new List<int>();
                int n = Convert.ToInt32(Console.ReadLine());
                string allSizes = Console.ReadLine();
                string[] sizes = allSizes.Split(' ');
                foreach(string size in sizes)
                {
                    sizesList.Add(Int32.Parse(size));
                }
                sizesList.Sort();

                int result = 1;
                int treatsForThisPet = 1;

                if (sizesList.Count == 1)
                {
                    result = 1;
                }
                else
                {
                    for (int k = 2; k <= sizesList.Count; k++)
                    {
                        int currentSize = sizesList[k - 1];
                        int earlierSize = sizesList[k - 2];
                        if (currentSize != earlierSize)
                        {
                            treatsForThisPet++;
                        }
                        result += treatsForThisPet;
                    }
                }
               
                Console.WriteLine("Case #{0}: {1}", x+1, result);
            }
        }
    }
}
