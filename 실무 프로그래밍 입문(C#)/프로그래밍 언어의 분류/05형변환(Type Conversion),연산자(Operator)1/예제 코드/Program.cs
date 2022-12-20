using System;
using System.Diagnostics.Eventing.Reader;

namespace 예제_코드
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char char1 =  'a';

            int int1 = char1; // 묵시적 변환 가능 16-> 32비트
            Console.WriteLine("int1: " + int1);

            long long1 = char1;
            Console.WriteLine("long1: " + long1);

            ulong ulong1 = char1;
            Console.WriteLine("ulong1: " + ulong1);

            float float1 = char1;
            Console.WriteLine("float1: " + float1);

            double double1 = char1;
            Console.WriteLine("double1: " + double1);
            // 위의 코드 전부다 값은 97

            long long2 = long.MaxValue; 
            int long2ToInt = (int)long2; //long -> int 는 묵시적으로 못하니 명시적으로함

            Console.WriteLine("long2: " + long2); // 최상위 비트만 0이고 나머지 비트는 다 1
            Console.WriteLine("long2ToInt: " + long2ToInt); //-1 

            float float2 = 3.14159f;
            int float2ToInt = (int)float2;

            Console.WriteLine("float2: " + float2); // 3.14159
            Console.WriteLine("float2ToInt: " + float2ToInt); //3

            int int2 = -1;
            uint int2ToUInt = (uint)int2;

            Console.WriteLine("int2ToUInt: " + int2ToUInt); 
            // 최대값이 나온다. 4294967295
        } 
    }
}
