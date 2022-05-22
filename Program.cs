using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter a string:");
            var inputText = Console.ReadLine();
            string lowerCase;
            lowerCase = inputText.ToLower();
            string s = lowerCase;
            s = Regex.Replace(s, @"(^\w)|(\s\w)", m => m.Value.ToUpper());
            Console.WriteLine("You entered :{0}", s);
            int i, len,vowel_count;
            vowel_count = 0;
            len = s.Length;
            for (i = 0; i < len; i++)
            {
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u' || s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U')
                {
                    vowel_count++;
                }
            }
            Console.Write("\nVowels in the string: {0}\n", vowel_count);

            Console.ReadLine();
            
            
        }

    }
}
