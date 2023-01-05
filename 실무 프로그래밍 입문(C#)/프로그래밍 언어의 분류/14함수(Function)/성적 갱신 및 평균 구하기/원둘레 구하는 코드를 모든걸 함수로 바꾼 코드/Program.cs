using System;

namespace 원둘레_구하는_코드를_모든걸_함수로_바꾼_코드
{
    class Program
    {
        static double GetRadius()
        {
            return double.Parse(Console.ReadLine());
        }

        static double CalculateCircumference(double r)
        {
            return 2 * 3.14 * r;
        }

        static void PrintMessage(string message)
        {
            Console.Write(message);
        }

        static void PrintRadius()
        {
            PrintMessage("Enter radius: ");
            double radius = GetRadius();

            double result = CalculateCircumference(radius);
            PrintMessage($"Radius = {radius} Circumference = {result}\n");

          }

        static void Main(string[] args)
        {
            PrintRadius();
        }
    }
}

