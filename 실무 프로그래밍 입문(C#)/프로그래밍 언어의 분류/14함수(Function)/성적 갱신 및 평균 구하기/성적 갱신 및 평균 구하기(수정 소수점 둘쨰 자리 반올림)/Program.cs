using System;
using System.Threading;

namespace 성적_갱신_및_평균_구하기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] scores = { 100.0, 35.4, 75.4, 54.6, 99.5 };

            double average = 0.0;
            for (int i = 0; i < scores.Length; i++)
            {
                average += scores[i];
            }
            average /= scores.Length;
            average = (int)(average * 10 + 0.5) / 10.0; //여기만 수정댐.

            Console.WriteLine("---------------------------");
            Console.WriteLine($"{scores.Length} scores average: {average:f1}");
            Console.WriteLine("---------------------------");

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
                    average = 0.0;
                    for (int i = 0; i < scores.Length; ++i)
                    {
                        average += scores[i];
                    }
                    average /= scores.Length;
                    average = (int)(average * 10) / 10.0; //여기는 까먹고 수정못한과정

                    Console.WriteLine("---------------------------");
                    Console.WriteLine($"{scores.Length} scores average: {average:f1}");
                    Console.WriteLine("---------------------------");
                }
            }
        }
    }
}
