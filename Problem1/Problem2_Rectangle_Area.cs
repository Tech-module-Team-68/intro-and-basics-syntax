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
            var second = double.Parse(Console.ReadLine());
            double sum = first * second;
            Console.WriteLine($"{sum:f2}");
           
        }
    }
}
