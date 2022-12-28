using System;

namespace 털리기_쉬운_로그인_프로그램
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string passcode = "0046a"; // 실제로 비밀번호는 이렇게 저장안함.
            string userInput = "";

            while (true)
            {
                Console.WriteLine("Please enter the password: ");
                userInput = Console.ReadLine(); 

                if (userInput == passcode) 
                {
                    Console.WriteLine("Correct! Welcome home!");
                    break;
                }

                Console.WriteLine("Wrong password!");
            }
        }
    }
}
