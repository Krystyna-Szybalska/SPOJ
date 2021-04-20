using System;

namespace CodeJam
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numberOfTestCases = Convert.ToByte(Console.ReadLine());
            for (byte i = 0; i < numberOfTestCases; i++)
            {
                string mnp = Console.ReadLine();
                string[] people = mnp.Split(' ');
                int managers = Int32.Parse(people[0]);
                int nonManagers = Int32.Parse(people[1]);
                int numberOfPairs = Int32.Parse(people[2]);

                for (int j = 0; j < managers + nonManagers; j++)
                {

                }
            }
        }
    }
}
