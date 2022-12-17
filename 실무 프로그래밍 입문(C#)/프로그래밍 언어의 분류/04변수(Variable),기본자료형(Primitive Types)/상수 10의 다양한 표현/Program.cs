using System;

namespace 상수_10의_다양한_표현
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intNum = 10;
            int binaryNum = 0b10;
            int hexNum = 0x10;
            uint uIntNum = 10u;
            float floatNum = 10.0f;
            double doubleNum = 10.0;
            string stringNum = "10";

            Console.WriteLine(intNum);
            Console.WriteLine(binaryNum);
            Console.WriteLine(hexNum);
            Console.WriteLine(uIntNum);
            Console.WriteLine(floatNum);
            Console.WriteLine(doubleNum);
            Console.WriteLine(stringNum);

        }
    }
}
