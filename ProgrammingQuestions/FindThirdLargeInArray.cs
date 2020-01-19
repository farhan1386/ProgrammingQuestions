using System;

namespace ProgrammingQuestions
{
    class FindThirdLargeInArray
    {
        static void Main()
        {
            int[] number = new int[5] { 10, 8, 5, 6, 3 };

            int max1 = int.MinValue;
            int max2 = int.MinValue;
            int max3 = int.MinValue;

            foreach (var item in number)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----Second Highest Number------");

            foreach (var item in number)
            {
                if (item > max2)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = item;
                }
                else if (item >max3 && item != max2 && item != max1)
                {
                    max3 = item;
                }
            }
            Console.WriteLine(max3);
            Console.ReadLine();
        }
    }
}
