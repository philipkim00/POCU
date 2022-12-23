using System;

namespace 조건외_나머지_처리하는_계산기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            string numStr1 = Console.ReadLine();
            int num1 = int.Parse(numStr1);

            Console.Write("Enter the second number: ");
            string numStr2 = Console.ReadLine();
            int num2 = int.Parse(numStr2);

            Console.Write("Enter an operator: ");
            string op = Console.ReadLine();

            if (op == "+")
            {
                Console.Write($"{num1} + {num2} = {num1 + num2}");
            }
            else if (op == "-")
            {
                Console.Write($"{num1} - {num2} = {num1 - num2}");
            }
            else if (op == "*")
            {
                Console.Write($"{num1} * {num2} = {num1 * num2}");
            }
            else if (op == "/") // 정확하지 않는 나숫셈
            {
                Console.Write($"{num1} / {num2} = {num1 / num2}");
            }
            else
            {
                Console.WriteLine($"You entered a wrong operator: {op}");
            }
        }
    }
}
