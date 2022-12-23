using System;

namespace 키보드로부터_두_숫자를_읽어_오기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            string num1 = Console.ReadLine();

            Console.WriteLine("Enter the second number: ");
            string num2 = Console.ReadLine();

            Console.WriteLine($"Num1: {num1}, Num2: {num2}");
        }
    }
}
