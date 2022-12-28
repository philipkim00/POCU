using System;

namespace 평균_구하기_for문_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numer of scores: ");
            int length = int.Parse(Console.ReadLine());
            int[] scores = new int[length];

            int totalScores = 0;
            for (int i = 0; i < length; ++i)
            {
                Console.Write($"Enter your score({i + 1}): ");
                scores[i] = int.Parse(Console.ReadLine());
                totalScores += scores[i];
            }

            Console.WriteLine($"Average = {totalScores / (float)length}");
        }
    }
}
