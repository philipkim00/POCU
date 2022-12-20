using System;

namespace 두_double_형_수를_더하기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 10.9;
            double num2 = 52.16;
            Console.WriteLine("일반 덧셈 결과: " + (num1 + num2));

            int result = (int)num1 + (int)num2;
            Console.WriteLine("명시적 형변환 덧셈 결과: " + result);
        }
    }
}
