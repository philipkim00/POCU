using System;

namespace 약간_수정한_동서남북_이동_프로그램
{
    internal class Program
    {
        static void Move(int direction, ref int x, ref int y)
        {
            switch (direction)
            {
                case NORTH :
                    y += 1;
                    break;
                case SOUTH:
                    y -= 1;
                    break;
                case EAST:
                    x += 1;
                    break;
                case WEST:
                    x += 1;
                    break;
                default:
                    Console.WriteLine($"You enter wrong direction!: {direction}");
                    break;
            }

        }
        static void Main(string[] args)
        {
            int direction;
            int x = 0;
            int y = 0;

            while (true)
            {
                Console.WriteLine($"Your location: ({x}, {y})");
                Console.WriteLine("Where do you want go? (N:1, S:2, E:3, W:4)");

                direction = int.Parse( Console.ReadLine() );
                Move(direction, ref x, ref y);
            }
        }
    }
}
