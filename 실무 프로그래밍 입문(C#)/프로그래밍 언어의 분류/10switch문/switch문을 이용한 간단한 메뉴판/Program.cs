using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch문을_이용한_간단한_메뉴판
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a meun");
            Console.WriteLine("1. Cheese burger");
            Console.WriteLine("2. Double cheesse burger");
            Console.WriteLine("3. Veggie burger");
            Console.WriteLine("4. Cheese & mushroom burger");

            int menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Console.WriteLine("You selected a cheese burger");
                    Console.WriteLine("Price: $3");
                    break;
                case 2:
                    Console.WriteLine("You selected a double cheese burger");
                    Console.WriteLine("Price: $4.50");
                    break;
                case 3:
                    Console.WriteLine("You selected a veggie burger");
                    Console.WriteLine("Price: $4");
                    break;
                case 4:
                    Console.WriteLine("You selected a mushroom burger");
                    Console.WriteLine("Price: $5");
                    break;
                default:
                    Console.WriteLine("Please enter a correct number(1~4)");
                    break;
            }

        }
    }
}
