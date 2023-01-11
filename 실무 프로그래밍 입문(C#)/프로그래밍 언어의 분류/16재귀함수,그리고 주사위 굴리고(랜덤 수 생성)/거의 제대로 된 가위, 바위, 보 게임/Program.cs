﻿using System;

namespace 거의_제대로_된_가위__바위__보_게임
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
            while (true)
            {
                Random random = new Random();
                EShape computer = (EShape)random.Next(3);

                Console.Write("Rock(0)~ paper(1)~ scissor(2)~: ");
                EShape user = (EShape)int.Parse(Console.ReadLine());

                if (computer == user)
                {
                    Console.WriteLine($"[Draw]\nYou({user}), Computer({computer})");
                }
                else if ((computer == EShape.Rock && user == EShape.Scissor)
                    || (computer == EShape.Paper && user == EShape.Rock)
                    || (computer == EShape.Scissor && user == EShape.Paper))

                {
                    Console.WriteLine($"[Lose]\nYou({user}), Computer({computer})");
                }

                else if ((computer == EShape.Rock && user == EShape.Paper)
                    || (computer == EShape.Paper && user == EShape.Scissor)
                    || (computer == EShape.Scissor && user == EShape.Rock))
                {
                    Console.WriteLine($"[Win]\nYou({user}), Computer({computer})");
                }
                else
                {
                    Console.WriteLine("Wrong input!");
                }
            }
        }
    }
}
