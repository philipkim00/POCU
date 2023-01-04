using System;


namespace 정수의_제곱을_구하는_프로그램
{
    internal class Program
    {
        static double Square(double number)
        {
            number *= number;

            return number;
        }
        static void Main(string[] args)
        {
            double number = 5;
            Console.WriteLine(Square(number));
        }
    }
}
