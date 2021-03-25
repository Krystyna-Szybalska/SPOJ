using System;

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
                string[] points = p.Split(' ');//może tu mu się coś nie podoba?
                long[] pointsLong = new long[points.Length];

                for (int j = 0; j < points.Length; j++) //obejście linq funkcji robiącej z tego longi: long[] pointsLong = points.Select(long.Parse).ToArray();
                {
                    long pointLong = Convert.ToInt64(points[j]);
                    pointsLong[j] = pointLong;
                }

                for (int k = 0; k < levelNumber; k++)
                {
                    currentLifePoints += pointsLong[k];
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
