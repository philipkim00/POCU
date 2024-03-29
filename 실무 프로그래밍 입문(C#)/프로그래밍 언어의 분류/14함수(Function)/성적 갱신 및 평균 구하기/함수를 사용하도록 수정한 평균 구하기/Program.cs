﻿using System;

namespace 함수를_사용하도록_수정한_평균_구하기
{
    internal class Program
    {
        static double Sum(double[] scores)
        {
            double sum = 0.0;
            for (int i = 0; i < scores.Length; ++i)
            {
                sum += scores[i];
            }

            return sum;
        }

        static double Average(double data, int count)
        {
            data /= count;
            data = (int)(data * 10 + 0.5) / 10.0;
            return data;
        }

        static void PrintAverage(double average, int count)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine($"{count} scroes average: {average:f1}");
            Console.WriteLine("-------------------------");
        }

        static void Main(string[] args)
        {
            double[] scores = { 100.0, 35.4, 75.4, 54.6, 99.5 };
            double average = Average(Sum(scores), scores.Length);
            PrintAverage(average, scores.Length);

            while (true)
            {
                for (int i = 0; i < scores.Length; ++i)
                {
                    Console.WriteLine($"Score{i}: {scores[i]}");
                }

                Console.WriteLine($"While score do you want to updata?(0~{scores.Length - 1})");
                int index = int.Parse(Console.ReadLine());
                if (index < 0 || index >= scores.Length)
                {
                    Console.WriteLine("Wrong index.");
                }
                else
                {
                    Console.Write("Entert the scores: ");
                    scores[index] = double.Parse(Console.ReadLine());
                    average = Average(Sum(scores), scores.Length);
                    PrintAverage(average, scores.Length);
                }
            }
        }

    }
}
