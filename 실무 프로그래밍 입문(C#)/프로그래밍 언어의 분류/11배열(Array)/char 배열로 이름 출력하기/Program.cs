using System;

namespace char_배열로_이름_출력하기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] myName = new char[4];

            myName[0] = 'L';
            myName[1] = 'u';
            myName[2] = 'l';
            myName[3] = 'u';

            Console.WriteLine($"My name is {myName[0]}{myName[1]}{myName[2]}{myName[3]}");
        }
    }
}
