using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checking_For_Duplicates_In_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString;
            Console.WriteLine("Enter String to be checked: ");
            testString = Console.ReadLine();
            bool doubleFound = false;
            int i = 0;

            char[] testArr = testString.ToLower().ToCharArray();
            Array.Sort(testArr);
            while (!doubleFound && i < testString.Count() - 1)
            {
                if (testArr[i] == testArr[i + 1])
                {
                    doubleFound = true;
                    Console.WriteLine("String contains a double: " + testString);
                }
                i++;
            }
            if (!doubleFound)
            {
                Console.WriteLine("No double was found!");
            }
            Console.ReadLine();
        }
    }
}
