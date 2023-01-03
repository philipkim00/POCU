using System;

namespace 함수_호출
{
    internal class Program
    {
        static int Add(int op1, int op2)
        {
            return op1 + op2;
        }

        static void Main(string[] args)
        {
            int result = Add(123, 589);
        }
    }
}
