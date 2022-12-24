using System;

namespace 둘_중_큰수를_출력하기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second numbert: ");
            int num2 = int.Parse(Console.ReadLine());

            int max;
            if (num1 > num2)
            {
                max = num1;
            }
            else
            {
                max = num2;
            }

            Console.WriteLine($"Max number is {max}");
        }
    }
}
