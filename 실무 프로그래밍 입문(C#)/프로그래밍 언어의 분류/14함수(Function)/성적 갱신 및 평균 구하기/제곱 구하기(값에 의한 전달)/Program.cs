using System;

namespace 제곱_구하기_값에_의한_전달_
{
    internal class Program
    {
        static void Square(double number)
        {
            number *=  number;
        }
        static void Main(string[] args)
        {
            double number = 5;
            Console.WriteLine($"Before: {number}");
            Square(number);
            Console.WriteLine($"After: {number}");
        }
    }
}
