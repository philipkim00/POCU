using System;

namespace 범위_scope_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] {1, -3, 4, -10, 4, 2, 9, 15 };
            double average = GetAverage(numbers);

            Console.WriteLine($"average: {average}");

            {
                // int average = 0; // 컴파일 에러
                string message = "Message in the first child scope!";
                Console.WriteLine(message);
            }

            {
                //int average = 0; // 컴파일 에러
                string message = "Message in the second chilld scope!";
                Console.WriteLine(message);
            }
        }

        static double GetAverage(int[] inputs) 
        {
            int sum = 0;

            //  for (int i = 0; i < numbers.Length; i++)
            //  {
            //    sum += numbers[i];
            //  }

            for (int i = 0; i < inputs.Length; i++) 
            {
                sum += inputs[i];
            }

            return (double)sum / inputs.Length;
        }
    }
}
