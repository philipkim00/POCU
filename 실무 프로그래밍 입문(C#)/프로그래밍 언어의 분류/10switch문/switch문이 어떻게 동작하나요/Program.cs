using System;

namespace switch문이_어떻게_동작하나요
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu = 2;

            switch (menu)
            {
                case 1:
                    Console.WriteLine("You selected a cheese burger");
                    break;
                case 2:
                    Console.WriteLine("You selected a double cheese burger");
                    break;
                case 3:
                    Console.WriteLine("Please enter a correct number");
                    break;
            }

        }
    }
}
