using Microsoft.SqlServer.Server;
using System;

namespace 무한_while반복문
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Input Number: ");
                string inputString = Console.ReadLine();
                int input = int.Parse(inputString);

                if (input == 0)
                {
                    break;
                }

                Console.WriteLine("Number in hex: 0x{0:x}", input);
            }
        }
    }
}
