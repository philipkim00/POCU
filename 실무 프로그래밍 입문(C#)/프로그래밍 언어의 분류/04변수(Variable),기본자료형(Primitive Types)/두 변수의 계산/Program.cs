using System;

namespace 두_변수의_계산
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1 = 10.0f; //첫 번쨰 변수
            float num2 = 20.0f; //두 반쨰 변수

            //두 숫자 더하기
            Console.Write(num1 + "+" + num2 + "=");
            Console.WriteLine(num1 + num2);

            //두 숫자 뺴기
            Console.Write(num1 + "-" + num2 + "=");
            Console.WriteLine(num1 - num2);

            //두 숫자 곱하기
            Console.Write(num1 + "*" + num2 + "=");
            Console.WriteLine(num1 * num2);

            //두 숫자 나누기
            Console.Write(num1 + "/" + num2 + "=");
            Console.WriteLine(num1 / num2);
        }
    }
}
