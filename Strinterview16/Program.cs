using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strinterview16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string; ");
            string text = Console.ReadLine();
            Console.Write("Enter a sub-string; ");
            string word = Console.ReadLine();
            bool result = searchText(text, word);
            Console.WriteLine("does \"" + text + "\" contain \"" + word + "\"?: " + result);
        }

        static bool searchText(string text, string search)
        {
            int tLen = text.Length;
            int sLen = search.Length;

            if (sLen > tLen) return false;

            for (int lcv = 0; lcv <= tLen - sLen; lcv++) {
                if (text.Substring(lcv, sLen) == search)
                    return true;
            return false;
            }

        }
    }
}
