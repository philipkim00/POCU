using System;

namespace 함수_호출시_인자는_변수_상수_다가능
{
    internal class Program
    {
        static int Add(int op1, int op2)
        {
            return op1 + op2;
        }

        static void Main(string[] args)
        {
            int result1 = Add(123, 589); // 상수 가능

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int result2 = Add(num1, num2); // 변수 가능
        }
    }
}
