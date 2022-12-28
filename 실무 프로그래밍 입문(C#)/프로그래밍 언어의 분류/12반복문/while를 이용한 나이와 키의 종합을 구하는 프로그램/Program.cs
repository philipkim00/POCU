using System;

namespace while를_이용한_나이와_키의_종합을_구하는_프로그램
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("User count: ");
            int length = int.Parse(Console.ReadLine());
            int[] ages = new int[length];
            float[] heights = new float[length];

            int totalAges = 0;
            float totalHeights = 0.0f;
            int count = 0;
            while (count < length)
            {
                Console.Write("Enter the first user's age: ");
                ages[count] = int.Parse(Console.ReadLine());
                totalAges += ages[count];

                Console.Write("Enter the first user's height(cm)");
                heights[count] = float.Parse(Console.ReadLine());
                totalHeights += heights[count];

                ++count;
            }
            Console.WriteLine($"Total ages: {totalAges}");
            Console.WriteLine($"Total heights: {totalHeights}");
        }
    }
}

