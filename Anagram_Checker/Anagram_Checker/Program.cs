using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord;
            string secondWord;
            char[] firstWordArr;
            char[] secondWordArr;
            string newFirstWord;
            string newSecondWord;

            Console.Write("Please enter the first word: ");
            firstWord = Console.ReadLine();
            Console.Write("Please enter the second word: ");
            secondWord = Console.ReadLine();

            firstWordArr = firstWord.ToLower().ToCharArray();
            secondWordArr = secondWord.ToLower().ToCharArray();

            newFirstWord = firstWordArr.ToString();
            newSecondWord = secondWordArr.ToString();

            if (newFirstWord == newSecondWord)
            {
                Console.WriteLine("These two words are anagrams!");
            }
            else
            {
                Console.WriteLine("These words are not anagrams!");
            }
            Console.ReadLine();
        }
    }
}
