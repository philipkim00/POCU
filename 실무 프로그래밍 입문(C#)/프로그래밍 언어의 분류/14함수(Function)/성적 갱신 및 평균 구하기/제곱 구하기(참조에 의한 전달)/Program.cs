using System;

namespace 제곱_구하기_참조에_의한_전달_
{
        internal class Program
        {
            static void Square(ref double number)
            {
                number *= number;
            }
            static void Main(string[] args)
            {
                double number = 5;
                Console.WriteLine($"Before: {number}");
                Square(ref number);
                Console.WriteLine($"After: {number}");
            }
        }
    }

