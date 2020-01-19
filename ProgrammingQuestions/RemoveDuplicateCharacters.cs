using System;
using System.Linq;

namespace ProgrammingQuestions
{
    class RemoveDuplicateCharacters
    {
        static void Main()
        {
            Console.WriteLine("Please eneter your name:");
            string name = Convert.ToString(Console.ReadLine());

            string result = string.Empty;

            for (int i = 0; i <name.Length; i++)
            {
                if (!result.Contains(name[i]))
                {
                    result += name[i];
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
