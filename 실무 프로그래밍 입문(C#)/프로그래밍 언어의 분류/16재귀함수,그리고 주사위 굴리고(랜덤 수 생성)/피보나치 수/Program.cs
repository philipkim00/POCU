using System;

namespace 피보나치_수
{
    internal class Program
    {
        public static int FibonacciRecursive(uint number)
        {
            if (number == 0)
            {
                return 0;
            }
            
            if (number == 1)
            {
                return 1;
            }

            return FibonacciRecursive(number - 2) + FibonacciRecursive(number - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FibonacciRecursive(10));
        }
    }
}
