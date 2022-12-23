using System;

namespace 코드의_문제점_찾기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your math score: ");
            string scoreString = Console.ReadLine();
            int score = int.Parse(scoreString);

            if (score >= 70)
            {
                Console.WriteLine("Pizza time!!");
            }
            else if (score >= 80)
            {
                Console.WriteLine("Buy some books");
            }
            else if (score >= 90)
            {
                Console.WriteLine("Buy a game console!!!!!");
            }
        }
    }
}
