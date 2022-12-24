using System;

namespace 올바른_수학_성적_보상_프로그램
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your math score: ");
            string scoreString = Console.ReadLine();
            int score = int.Parse(scoreString);

            if (score >= 90)
            {
                Console.WriteLine("Game console");
            }
            else if (score >= 80)
            {
                Console.WriteLine("Comic books");
            }
            else if (score >= 70)
            {
                Console.WriteLine("Pizza");
            }
            else
            {
                Console.WriteLine("Sorry!");
            }
        }
    }
}
