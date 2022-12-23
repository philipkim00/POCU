using System;

namespace 이름과_학번_출력3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Lulu";
            int id = 201900001;

            //방법1
            string messige1 = string.Format($"Student Name: {name} / Student ID: {id}");
            Console.WriteLine(messige1);

            //방법2
            Console.WriteLine($"Student Name: {name} / Student ID: {id}");
        }
    }
}
