using System;

namespace 기본자료형2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 부호없는 8비트 수
            byte byte1 = byte.MaxValue; // 최대값 255
            byte byte2 = byte.MinValue; // 최솟값 0


            int int1 = int.MaxValue; //2,147,483,647
            int int2 = int.MinValue; //-2,147,483,648

            long long1 = long.MinValue; //존나큼
            long long2 = long.MaxValue; //존나 작음

            char char1 = 'x';
            char char2 = '$';

            // 변수들을 2진수로 변환하는것. 
            Console.WriteLine(byte1 + " -> " + Convert.ToString(byte1, 2)); // 1111 1111
            Console.WriteLine(byte2 + " -> " + Convert.ToString(byte2, 2)); // 0000 0000

            Console.WriteLine(int1 + " -> " + Convert.ToString(int1, 2)); 
            // 0111 1111 1111 1111 1111 1111 1111 1111
            Console.WriteLine(int2 + " -> " + Convert.ToString(int2, 2));
            // 1000 0000 0000 0000 0000 0000 0000 0000

            Console.WriteLine(long1 + " -> " + Convert.ToString(long1, 2)); //너무김
            Console.WriteLine(long2 + " -> " + Convert.ToString(long2, 2)); //너무 김

            Console.WriteLine(char1 + " -> " + Convert.ToString(char1, 2)); 
            Console.WriteLine(char2 + " -> " + Convert.ToString(char2, 2));

        }
    }
}
