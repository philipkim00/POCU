using System;

namespace 게임_승률_출력하기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studnetName1 = "Kim Leon";
            float winRate1 = 30.2351f;

            string studentName2 = "Lulu";
            float winRate2 = 70.11f;

            Console.WriteLine("{0}    {1}\n", "Name", "Win Rate");
            Console.WriteLine("{0}    {1}\n", studnetName1, winRate1);
            Console.WriteLine("{0}    {1}\n", studentName2, winRate2);
        }
    }
}
