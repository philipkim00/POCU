using System;

namespace 거듭제곱_구하기
{
    internal class Program
    {
        static void Square(double number)
        {
            double result = number * number;
        }
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            Square(num);
            Console.WriteLine($"Result: {result}");
        }
    }
}
