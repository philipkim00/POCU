using System;

namespace 로그인_하기_for문_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string passcode = "0046a";

            string userInput = "";

            for (; ; )
            {
                Console.Write("Please enter the password: ");
                userInput = Console.ReadLine();

                if (passcode == userInput)
                {
                    Console.WriteLine("Correct! Welcome home!");
                    break;
                }
            }
            
            Console.WriteLine("Wrong password!");
        }
    }
}