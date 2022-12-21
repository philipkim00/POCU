using System;

namespace 비트_이동_연산자로_2씩_곱하고_나누기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;

            int result1 = num1 << 1; // 2(2를 곱하는 것과 동일)

            Console.WriteLine("result1: " + result1);

            int result2 = result1 << 2; //8(2^2를 곱하는 것과 동일)

            Console.WriteLine("result2: " + result2);

            int result3 = result2 >> 3; // 2(2^3를 나누는 것과 동일)

            Console.WriteLine("result3: " + result3);

            // int result4 = result3 << 2.5f;
            // int result5 = 2.1f << 2.5f;
            // 비트이동연산자에 우항으로 부동소수점 수는 사용불가능 
            // 이유: 비트가 가장 작은수인데 소수점으로 이동불가.
        }
    }
}
