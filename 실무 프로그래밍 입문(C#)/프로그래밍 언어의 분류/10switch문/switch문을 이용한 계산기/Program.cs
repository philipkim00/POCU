using System;

namespace switch문을_잉요한_계산기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("num1: ");
            string num1String = Console.ReadLine();
            int num1 = int.Parse(num1String);

            Console.WriteLine("num2: ");
            string num2String = Console.ReadLine();
            int num2 = int.Parse(num2String);

            Console.WriteLine("operation (+,-,*,/): ");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;
                case "/":
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    break;
                default:
                    Console.WriteLine($"You entered a wwrong operator: {operation}");
                    break;
            }

        }
    }
}
