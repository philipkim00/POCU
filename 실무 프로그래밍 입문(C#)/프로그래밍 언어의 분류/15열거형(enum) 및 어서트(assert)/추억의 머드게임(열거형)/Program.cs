using System;

namespace 추억의_머드게임_열거형_
{
    internal class Program
    {
        enum EDirection
        {
            North,
            South,
            East,
            West,
        };
        static void Main(string[] args)
        {
            EDirection direction;
            int x = 0;
            int y = 0;

            while (true)
            {
                Console.WriteLine($"Your location: ({x}, {y})");
                Console.WriteLine("Where do you want go? (N:1, S:2, E:3, W:4");
                direction = (EDirection)int.Parse(Console.ReadLine());
                switch (direction)
                {
                    case EDirection.North:
                        y += 1;
                        break;
                    case EDirection.South:
                        y += 1;
                        break;
                    case EDirection.East:
                        x += 1;
                        break;
                    case EDirection.West:
                        x -= 1;
                        break;
                    default:
                        Console.WriteLine($"You enter wrong direction!: {direction}");
                        break;
                }
            }
        }
}
