using System;

namespace 원둘레_구하기_함수로_안_분리_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius: ");
            double radius = double.Parse(Console.ReadLine());

            double result = 2 * 3.14 * radius;
            Console.WriteLine($"Radius = {radius} Circumference = {result}");
        }
    }
}
