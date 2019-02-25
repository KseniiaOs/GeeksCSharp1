using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1Q2
{
    class Program
    {   
        static void Main(string[] args)
           
        {
            double i;
            Console.WriteLine("Your height:");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your weight:");
            double m = Convert.ToDouble(Console.ReadLine());
            i =  m / ( h * h);
            Console.WriteLine(i);

            Console.ReadKey();


        }
    }
}
