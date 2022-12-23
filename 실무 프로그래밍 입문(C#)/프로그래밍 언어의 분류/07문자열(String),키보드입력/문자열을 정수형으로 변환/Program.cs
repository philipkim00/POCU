using System;

namespace 문자열을_정수형으로_변환
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            string numStr1 = Console.ReadLine();
            int num1 = int.Parse(numStr1);

            Console.WriteLine("Enter the second number: ");
            string numStr2 = Console.ReadLine();
            int num2 = int.Parse(numStr2);

            int result = num1 + num2;
            Console.WriteLine($"Num1: {num1}, Num2: {num2} = {result}");
        }
    }
}
