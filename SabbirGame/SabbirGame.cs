using System;

namespace SabbirGame
{
    class SabbirGame
    {
        static void Main(string[] args)
        {
            byte numberOfTestCases = Convert.ToByte(Console.ReadLine());
            long currentLifePoints;
            long minLifePoints;
            for (byte i = 0; i < numberOfTestCases; i++)
            {
                currentLifePoints = 0;
                minLifePoints = 1;
                int levelNumber = Convert.ToInt32(Console.ReadLine());
                string entryPoints = Console.ReadLine();
                string[] points = entryPoints.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int[] pointsInt = new int[points.Length];

                for (int j = 0; j < points.Length; j++)
                {
                    int pointInt = Convert.ToInt32(points[j]);
                    pointsInt[j] = pointInt;
                }

                for (int k = 0; k < levelNumber; k++)
                {
                    currentLifePoints += pointsInt[k];
                    if (currentLifePoints < minLifePoints) { minLifePoints = currentLifePoints; }
                }

                if (minLifePoints > 0) { Console.WriteLine(0); }
                else { Console.WriteLine(1 - minLifePoints); }
            }
        }
    }
}
