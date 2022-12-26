using System;

namespace 배열을_이용한_나이와_키_입출력
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ages = new int[3];
            float[] heights = new float[3];

            Console.Write("Enter the first user's age: ");
            ages[0] = int.Parse(Console.ReadLine());
            Console.Write("Enter the first user's height(cm)");
            heights[0] = float.Parse(Console.ReadLine());

            Console.Write("Enter the second user's age: ");
            ages[1] = int.Parse(Console.ReadLine());
            Console.Write("Enter the second user's height(cm)");
            heights[1] = float.Parse(Console.ReadLine());

            Console.Write("Enter the third user's age: ");
            ages[2] = int.Parse(Console.ReadLine());
            Console.Write("Enter the third user's height(cm)");
            heights[2] = float.Parse(Console.ReadLine());

            Console.WriteLine("Print result--------");
            Console.WriteLine($"The first User: Age({ages[0]}), Height({heights[0]}cm)");
            Console.WriteLine($"The first User: Age({ages[1]}), Height({heights[1]}cm)");
            Console.WriteLine($"The first User: Age({ages[2]}), Height({heights[2]}cm)");
        }
    }
}
