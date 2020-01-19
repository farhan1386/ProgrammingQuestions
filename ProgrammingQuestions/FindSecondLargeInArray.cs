using System;

namespace ProgrammingQuestions
{
    class FindSecondLargeInArray
    {
        static void Main()
        {
            int[] number = new int[5] { 10,8,5,6,3};

            int max1 = int.MinValue;
            int max2 = int.MinValue;

            foreach (var item in number)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----Second Highest Number-----");
            foreach (var item in number)
            {
                if (item > max1)
                {
                    max2 = max1;
                    max1 = item;
                }
                else if(item>max2 &&item!=max1)
                {
                    max2 = item;
                }
            }
            Console.WriteLine(max2);
            Console.ReadLine();
        }
    }
}
