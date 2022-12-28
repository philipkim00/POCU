using System;

namespace do_while반복문을_이용한_나이와_키_프로그램
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
            do
            {
                Console.Write("Enter the first user's age: ");
                ages[count] = int.Parse(Console.ReadLine());
                totalAges += ages[count];

                Console.Write("Enter the first user's height(cm)");
                heights[count] = float.Parse(Console.ReadLine());
                totalHeights += heights[count];

                ++count;
            } while (count < length);


            Console.WriteLine($"Total ages: {totalAges}");
            Console.WriteLine($"Total heights: {totalHeights}");
        }
    }
}
