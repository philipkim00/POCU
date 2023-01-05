using System;

namespace 원둘레_구하기_함수로_분리_
{
    internal class Program
    {
        static double CalculateCircumference(double r)
        {
            return 2 * 3.14 * r;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter radius: ");
            double radius = double.Parse(Console.ReadLine());

            double result = CalculateCircumference(radius);
            Console.WriteLine($"Radius ={radius} Circumference = {result}");
        }
    }
}
