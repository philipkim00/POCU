using System;

namespace _1부터_100까지의_합_구하기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MAX = 100;

            Console.WriteLine($"Sum of 1 - {MAX}");

            int sum = 0;
            for (int i = 0; i < MAX; i++) //for (int i =1; i <= MAX; i++) 해도 상관은 없
            {
                sum += (i + 1); // sum += i 
            }

            Console.WriteLine(sum);
        }
    }
}
