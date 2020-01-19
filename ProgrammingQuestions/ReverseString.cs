using System;

namespace ProgrammingQuestions
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string str = Convert.ToString(Console.ReadLine());

            char[] charArray = str.ToCharArray();
            for (int i = 0, j=str.Length-1; i<j; i++,j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }
            string reversestring = new string(charArray);
            Console.WriteLine(reversestring);
            Console.ReadLine();
        }
    }
}
