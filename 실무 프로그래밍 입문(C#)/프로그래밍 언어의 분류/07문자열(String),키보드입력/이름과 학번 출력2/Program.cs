using System;

namespace 이름과_학번_출력2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Lulu";
            int id = 201900001;

            //방법1
            string messige1 = string.Format("Student Name: {0} / Student ID: {1}", name, id);
            Console.WriteLine(messige1);

            //방법2
            Console.WriteLine("Student Name: {0} / Student ID: {1}", name, id);
        }
    }
}
