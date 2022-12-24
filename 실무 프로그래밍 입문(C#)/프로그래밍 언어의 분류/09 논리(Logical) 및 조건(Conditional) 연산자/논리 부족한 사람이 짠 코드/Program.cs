using System;
using System.Xml.Schema;

namespace 논리_부족한_사람이_짠_코드
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
            else if (score < 90 && score >= 80)
            {
                Console.WriteLine("Comic books");
            }
            else if (score < 80 && score >= 70)
            {
                Console.WriteLine("Pizza");
            }
            else
            {
                Console.WriteLine("Sorry! Try next time!");
            }
        }
    }
}
