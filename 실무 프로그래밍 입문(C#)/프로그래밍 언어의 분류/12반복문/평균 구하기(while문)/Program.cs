using System;

namespace 평균_구하기_while문_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numer of scores: ");
            int length = int.Parse(Console.ReadLine());
            int[] scores = new int[length];

            int totalScores = 0;
            int count = 0;
            while (count < length)
            {

                Console.Write($"Enter your score({count + 1}): ");
                scores[count] = int.Parse(Console.ReadLine());
                totalScores += scores[count];
                ++count;
            }

            Console.WriteLine($"Average = {totalScores / (float)length}");
        }
    }
}
