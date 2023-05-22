using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Str_Interview8
{
    class Program
    {
        static void Main(string[] args)
        {
            int ans = 0;
            Console.Write("Enter string of text.");
            string str = Console.ReadLine();
            Console.Write("Enter the letter you wish to find the number of.");
            string find = Console.ReadLine();
            char findo = char.Parse(find);

            for (int num = 0; num < str.Length; num++)
            {
                if (str[num] == findo)
                    ans++;
            }
            Console.WriteLine("There are " + ans + " of your chosen letter in your string.");
            Console.ReadKey();

        }
    }
}
