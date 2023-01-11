using System;

namespace 언제나_정해진_게임
{
    enum EShape
    {
        Rock,
        Scissor,
        Paper
    };
    internal class Program
    {
        static void Main(string[] args)
        {
            EShape computer = EShape.Paper;

            while(true)
            {
                Console.WriteLine("Rock(0)~ paper(1)~ scissor(2)~: ");
                EShape user = (EShape)int.Parse(Console.ReadLine());

                if (computer == user)
                {
                    Console.WriteLine("Draw");
                }
                else if ((computer == EShape.Rock && user == EShape.Scissor)
                    || (computer == EShape.Paper && user == EShape.Rock)
                    || (computer == EShape.Scissor && user == EShape.Paper))

                {
                    Console.WriteLine("Lose");
                }

                else if ((computer == EShape.Rock && user == EShape.Paper)
                    || (computer == EShape.Paper && user == EShape.Scissor)
                    || (computer == EShape.Scissor && user == EShape.Rock))
                {
                    Console.WriteLine("Win");
                }
                else
                {
                    Console.WriteLine("Wrong input!");
                }
            }
        }
    }
}
