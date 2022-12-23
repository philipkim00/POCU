using System;

namespace _10진수를_16진수로_출력하기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", 10);
            Console.WriteLine("{0:x}", 10); // 소문자
            Console.WriteLine("{0:X}", 10); // 대문자
            Console.WriteLine("{0:x1}", 10);
            Console.WriteLine("{0:x2}", 10);
            Console.WriteLine("{0:x3}", 10);
            Console.WriteLine("{0:x4}", 10);
        }
    }
}
