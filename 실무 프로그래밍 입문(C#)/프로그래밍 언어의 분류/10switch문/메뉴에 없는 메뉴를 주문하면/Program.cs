using System;

namespace 메뉴에_없는_메뉴를_주문하면
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu = 3;

            switch (menu)
            {
                case 1:
                    Console.WriteLine("You selected a cheese burger");
                    break;
                case 2:
                    Console.WriteLine("You selected a double cheese burger");
                    break;
                default:
                    Console.WriteLine("Please enter a correct number");
                    break;
            }
        }
    }
}
