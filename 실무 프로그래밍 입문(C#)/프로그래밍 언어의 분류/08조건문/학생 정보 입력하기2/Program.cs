using System;

namespace 학생_정보_입력하기2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's fill out student information: ");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Grade: ");
            string gradeString = Console.ReadLine();
            int grade = int.Parse(gradeString);

            if (grade >= 90)
            {
                Console.WriteLine("Excellent! Youu are an A sutdent!");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("Good! You are above average!");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("성적이 어쩌구저꺼구");
            }
            else if (grade >= 50)
            {
                Console.WriteLine("다시 시도해");
            }
            else
            {
                Console.WriteLine("흠 넌 코딩에 재능이없어.");
            }
        }
    }
}
