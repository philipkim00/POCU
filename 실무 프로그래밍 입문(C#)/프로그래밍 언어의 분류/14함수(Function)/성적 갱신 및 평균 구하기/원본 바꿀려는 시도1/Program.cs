using System;

namespace 원본_바꿀려는_시도1
{
    internal class Program
    {
        static double Square(double number)
        {
           return number *= number;
        }
        static void Main(string[] args)
        {
            double number = 5;
            Console.WriteLine($"Before: {number}");
            number = Square(number);
            Console.WriteLine($"After: {number}");
        }
    }
}
