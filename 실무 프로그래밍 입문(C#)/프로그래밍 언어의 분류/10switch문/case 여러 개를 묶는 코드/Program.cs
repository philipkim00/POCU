using System;

namespace case_여러_개를_묶는_코드
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your grade?");
            Console.WriteLine("1. Elementary school(1-6 hrade)");
            Console.WriteLine("2. Middle school(1-3 hrade)");
            Console.WriteLine("3. High school(1-3 hrade)");
            Console.WriteLine("4. College, university or graduated school student");

            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.WriteLine("Fare: $1");
                    break;
                case 2:
                case 3:
                    Console.WriteLine("Farres: $1.50");
                    break;
                case 4:
                    Console.WriteLine("Fare: $2");
                    break;
                default:
                    Console.WriteLine("Fare: $3");
                    break;
            }

        }
    }
}
