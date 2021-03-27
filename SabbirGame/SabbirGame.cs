using System;

namespace SabbirGame
{
    class SabbirGame
    {
        static void Main(string[] args)
        {
            byte numberOfTestCases = Convert.ToByte(Console.ReadLine());
            long currentLifePoints = 0;
            long minLifePoints = 1;
            for (byte i = 0; i < numberOfTestCases; i++)
            {
                short levelNumber = Convert.ToSByte(Console.ReadLine());
                string p = Console.ReadLine();
                string[] points = p.Split(' ', StringSplitOptions.RemoveEmptyEntries);
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
                currentLifePoints = 0;
                minLifePoints = 1;
            }
        }
    }
}
