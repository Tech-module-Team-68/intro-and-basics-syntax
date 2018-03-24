using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exs1
{
    class Program
    {
        static void Main(string[] args)
        {
           

            var first = double.Parse(Console.ReadLine());
           
            double sum = first * 1.60934;
            Console.WriteLine($"{sum:f2}");
           
        }
    }
}

