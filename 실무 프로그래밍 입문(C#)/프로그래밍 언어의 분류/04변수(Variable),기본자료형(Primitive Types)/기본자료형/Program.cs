﻿using System;

namespace 기본자료형
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int int1 = 2; 
            int int2 = 10;

            float float1 = 10.23f;
            float float2 = 3.4f;

            double double1 = 11.0;
            double double2 = 5.234;

            char char1 = 'x';
            char char2 = '$';

            Console.WriteLine(int1 + "+" + int2 + "=" + (int1 + int2));
            Console.WriteLine(int1 + "-" + int2 + "=" + (int1 - int2));
            Console.WriteLine(float1 + "+" + float2 + "=" + (float1 + float2));
            Console.WriteLine(double1 + "+" + double2 + "=" + (double1 + double2));
            Console.WriteLine(double1 + "-" + double2 + "=" + (double1 - double2));
        }
    }
}
