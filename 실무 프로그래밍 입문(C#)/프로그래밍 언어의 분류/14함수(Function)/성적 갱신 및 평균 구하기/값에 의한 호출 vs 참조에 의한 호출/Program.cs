using System;

namespace 값에_의한_호출_vs_참조에_의한_호출
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;

            IncrementByValye(num1, 2, 5);

            Console.WriteLine($"num1 after IncrementByValue(): {num1}");

            IncrementByRefererence(ref num1, 2, 5);

            Console.WriteLine($"num1 after IncrementByRefererence(): {num1}");
        }

        static void IncrementByValye(int num, int increment, int incrementCount)
        {
            for (int i = 0; i < incrementCount; i++)
            {
                num += increment;
            }
        }
        static void IncrementByRefererence(ref int num, int increment, int incrementCount)
        {
            for (int i = 0; i < incrementCount; i++)
            {
                num += increment;
            }
        }
    }
}
