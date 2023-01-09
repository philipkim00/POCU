using System;
using System.Diagnostics;

namespace 어서트_추가한_카레_메뉴_프로그램
{
    internal class Program
    {
        enum EMenu
        {
            Menu1 = 1,
            Menu2,
            Menu3,
            Menu4,
            Menu5,
            Menu6,
        }

        static double GetPrice(EMenu menu)
        {
            switch (menu)
            {
                case EMenu.Menu1:
                    return 10000;
                case EMenu.Menu2:
                    return 11000;
                case EMenu.Menu3:
                    return 12000;
                case EMenu.Menu4:
                    return 13000;
                case EMenu.Menu5:
                    return 14000;
                default:
                    Debug.Assert(false, ($"Wrong menu number!");
                    return -1;
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write($"Select the menu(1~5): ");
                EMenu menu = (EMenu)int.Parse(Console.ReadLine());

                double price = GetPrice(menu);
                Console.WriteLine($"You will pay {price} won");
            }
        }
    }
}
