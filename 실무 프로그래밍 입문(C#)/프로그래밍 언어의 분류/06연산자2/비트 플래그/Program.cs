using System;

namespace 비트_플래그
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int BIT_FLAG_SIZE = 8;
            // 1바이트 안에 몇 개의 비트가 들어갈수 잇는지를 정의.

            byte bitFlags = 0; // 모든 8개의 불리언 형태의 데이터가 꺼져있다.(거짓)

            byte mask1 = 1 << 2; // 오른쪽에서 세 번쨰 비트 참(1)로 설정 0000 0100

            bitFlags |= mask1; // bitFlags에 or연산자 사용해서0000 0000 | 0000100으로 설정.

            Console.WriteLine("bitFlags: " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0'));

            byte mask3 = (1 << 3) | (1 << 5); 
            // 오른쪽에서 네 번쨰 비트와 여섯 번쨰 참(1)로 설정 0010 1000

            bitFlags |= mask3; // 0000 0100 | 0010 1000 , 결과: 0010 1100

            Console.WriteLine("bitFlags: " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0'));

            bitFlags &= (byte)~mask1; // 3번쨰 비트 끄는 설정.
            // 1111 1011 &= 0010 1100 , 결과: 0010 1000

            Console.WriteLine("bitFlags: " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0'));

            bitFlags &= 0; //모든 비트 끄는 설정.

            Console.WriteLine("bitFlags: " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0'));

            char char1 = 'A'; //아스키코드 65번 
            int result1 = char1 | ' '; // 스페이스는 아스키 코드 32번

            Console.WriteLine("result1: " + (char)result1); // 소문자 a 출력

            char char2 = 'a';
            int result2 = char2 & '_';
        }

    }
}
