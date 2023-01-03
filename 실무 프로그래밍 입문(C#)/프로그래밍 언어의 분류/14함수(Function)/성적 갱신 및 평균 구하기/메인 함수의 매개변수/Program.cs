using System;

namespace 메인_함수의_매개변수
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for  (int i = 0; i< args.Length; ++i)
            {
                Console.WriteLine($"arhs[{i}] = {args[i]}");
            }
        }
    }
}
