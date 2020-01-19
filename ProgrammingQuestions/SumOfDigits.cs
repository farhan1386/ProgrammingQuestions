using System;

namespace ProgrammingQuestions
{
    class SumOfDigits
    {
        static void Main()
        {
            Console.WriteLine("Please inter number:");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            while (number>0)
            {
                sum += number%10;
                number /= 10;
            }
            Console.WriteLine(sum);
            Console.ReadLine();

        }
    }
}
