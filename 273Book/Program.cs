using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _273Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number of Books Purchased This Month: ");
            int num = int.Parse(Console.ReadLine());
            int points = 0;
            if (num == 0) points = 0;
            else if (num == 1) points = 5;
            else if (num == 2) points = 15;
            else if (num == 3) points = 30;
            else if (num >= 4) points = 60;
            Console.WriteLine("You have: " + points + " points");
            Console.ReadLine();
        }
    }
}
