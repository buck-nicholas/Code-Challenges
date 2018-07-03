using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            bool palindrome = true;
            int i = 0;

            Console.Write("Please enter the word: ");
            word = Console.ReadLine();

            char[] wordArr = word.ToLower().ToCharArray();

            while(palindrome && i < wordArr.Count() / 2)
            {
                if (wordArr[i] != wordArr[wordArr.Count() - i - 1])
                {
                    palindrome = false;
                }
                i++;
            }
            if (palindrome)
            {
                Console.WriteLine("Your word is a palindrome!");
            }
            else
            {
                Console.WriteLine("Your word is not a palindrome!");
            }
            Console.ReadLine();

        }
    }
}
