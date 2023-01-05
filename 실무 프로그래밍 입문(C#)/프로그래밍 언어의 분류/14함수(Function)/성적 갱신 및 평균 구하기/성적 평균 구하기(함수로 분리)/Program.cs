using System;

namespace 성적_평균_구하기_함수로_분리_
{
    internal class Program
    {
        static double CalculateAverage(double data, int count)
        {
            data /= count;
            data = (int)(data * 10 + 0.5) / 10.0;

            return data;
        }

        static void PrintAverageScore(double average, int count)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine($"{count} scores average: {average:f1}");
            Console.WriteLine("---------------------------");
        }
        static void Main(string[] args)
        {
            double[] scores = { 100.0, 35.4, 75.4, 54.6, 99.5 };

            double average = 0;
            for (int i = 0; i < scores.Length; ++i)
            {
                average += scores[i];
            }

            average = CalculateAverage(average, scores.Length);
            PrintAverageScore(average, scores.Length);

            while (true)
            {
                for (int i = 0; i < scores.Length; ++i)
                {
                    Console.WriteLine($"Score[i]:  {scores[i]}");
                }

                Console.WriteLine($"While score do you want to update?(0~{scores.Length - 1})");

                int index = int.Parse(Console.ReadLine());

                if (index < 0 || index >= scores.Length)
                {
                    Console.WriteLine("Wrong index.");
                }
                else
                {
                    Console.Write("Enter the score: ");
                    scores[index] = double.Parse(Console.ReadLine());

                    average = 0;
                    for (int i = 0; i < scores.Length; ++i)
                    {
                        average += scores[i];
                    }

                    average = CalculateAverage(average, scores.Length);
                    PrintAverageScore(average, scores.Length);
                }
            }
        }
    }
}
