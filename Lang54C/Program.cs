using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lang54C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Diameter: ");
            int dia = int.Parse(Console.ReadLine());
            double rad = (double)dia / 2;
            double cir = (double)(rad * 2) * 3.14159;
            double area = (double)(rad * rad) * 3.14159;

            Console.WriteLine("The Radius is " + rad);
            Console.WriteLine("The Circumference is " + Math.Round(cir,2));
            Console.WriteLine("The Area is " + Math.Round(area, 2));
            Console.ReadKey();

        }
    }
}
