using System;

namespace 계산기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 11;

            int result1 = num1 + num2;
            int result2 = num1 - num2;
            Console.WriteLine("result1: " + result1);
            Console.WriteLine("result2: " + result2);

            uint result3 = (uint)num1 - (uint)num2; 
            Console.WriteLine("result3: " + result3); // 4294967295

            int num3 = int.MaxValue;
            int result4 = num3 + 1;

            Console.WriteLine("result4: " + result4); //오버플로우 일어나서 가장 작은수 나옴.
            // -2147483648

            float num4 = 2.3f;

            float result5 = num1 + num4;
            float result6 = num4 - num1;

            Console.WriteLine("result5: " + result5); // 12.3
            Console.WriteLine("result6: " + result6); // -7.7
            // num1의 정수형은 flaot형으로 승격한다.

            float result7 = num2 * num4;
            Console.WriteLine("result7: " + result7); // 25.3

            float result8 = num2 / num1; // 1
            float result9 = num2 / (float)num1; //1.1
            Console.WriteLine("result8: " + result8);
            Console.WriteLine("result9: " + result9);

            int result10 = num1 % num2;
            int result11 = num2 % num1;
            Console.WriteLine("result10: " + result10); // 10
            Console.WriteLine("result11: " + result11); // 1
        }
    }
}
