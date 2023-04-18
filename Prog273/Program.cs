using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog273
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the mass of the object: ");
            int num1 = int.Parse(Console.ReadLine());
            double num2 = (double)num1 * 9.8;
            if (num2 < 10){
                Console.Write("Too Light");
            }
            if (num2 > 1000){
                Console.Write("Too Heavy");
            }
            else { Console.WriteLine("The weight of the object is: " + num2 + " newtons"); }
            Console.ReadKey();
        }
    }
}
