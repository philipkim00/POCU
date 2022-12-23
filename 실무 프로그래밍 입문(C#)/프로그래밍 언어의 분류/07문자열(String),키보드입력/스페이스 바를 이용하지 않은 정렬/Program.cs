using System;

namespace 스페이스_바를_이용하지_않은_정렬
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studnetName1 = "Kim Leon";
            float winRate1 = 30.2351f;

            string studentName2 = "Lulu";
            float winRate2 = 70.11f;

            Console.WriteLine("{0,10}{1,15}\n", "Name", "Win Rate");
            Console.WriteLine("{0,10}{1,15}\n", studnetName1, winRate1);
            Console.WriteLine("{0,10}{1,15}\n", studentName2, winRate2);
        }
    }
}
