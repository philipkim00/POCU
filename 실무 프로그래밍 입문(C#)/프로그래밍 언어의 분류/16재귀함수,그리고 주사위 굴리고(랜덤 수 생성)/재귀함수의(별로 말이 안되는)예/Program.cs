using System;

namespace 재귀함수의_별로_말이_안되는_예
{
    internal class Program
    {
        static uint SumRecursive(uint num)
        {
            if (num == 0)
            {
                return 0;
            }
            else
            {
                return num + SumRecursive(num - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SumRecursive(3));
        }
    }
}
