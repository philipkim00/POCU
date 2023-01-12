using System;

namespace _2D배열을_이용한_학생_명부
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int CLASS_COUNT = 3;
            const int STUDENT_COUNT = 5;

            string[,] classrooms = new string[CLASS_COUNT, STUDENT_COUNT]
                {
                    { "Severus","Draco", "Bellatrix", "", "" },
                    { "Cedric", "Hannah", "", "", "" },
                    { "Hermione", "Harry", "Leville", "Parvati", "Ron" }
                };
            
            for (int i = 0; i < CLASS_COUNT; ++i)
            {
                Console.WriteLine($"Class{i + 1} Info*****************");
                for (int j = 0; j < STUDENT_COUNT; ++j )
                {
                    Console.WriteLine($"Student{j + 1} name: {classrooms[i, j]}");
                }
                Console.WriteLine("*******************************");
            }

        }
    }
}
