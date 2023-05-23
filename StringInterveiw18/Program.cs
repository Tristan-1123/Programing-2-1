using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInterveiw18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String. ");
            string str = Console.ReadLine();
            Console.Write("Enter the Letter You Wish To Remove. ");
            string rem = Console.ReadLine();
            char remove = char.Parse(rem);
            string answer = "";

            for (int num = 0; num < str.Length; num++)
            {
                if (str[num] != remove)
                    answer += str[num];
            }
            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}
