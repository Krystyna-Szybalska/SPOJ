using System;
using System.Linq;

namespace SabbirGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTestCases = Convert.ToInt32(Console.ReadLine());
            long currentLifePoints = 0;
            long minLifePoints = 1;
            for (int i = 0; i < numberOfTestCases; i++)
            {
                int levelNumber = Convert.ToInt32(Console.ReadLine());
                string p = Console.ReadLine();
                string[] points = p.Split(' ');
                long[] pointsLong = points.Select(long.Parse).ToArray();

                for (int j = 0; j < levelNumber; j++)
                {
                    currentLifePoints += pointsLong[j];
                    if (currentLifePoints < minLifePoints) { minLifePoints = currentLifePoints; }
                }

                if (minLifePoints > 0) { Console.WriteLine(0); }
                else { Console.WriteLine(1 - minLifePoints); }
                currentLifePoints = 0;
                minLifePoints = 1;
            }
        }
    }
}
