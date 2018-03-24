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
           
			// Convert miles to kilometers; miles are read from the console
			
            var first = double.Parse(Console.ReadLine()); // miles
           
            double distance_km = first * 1.60934; // kilometers
			
            Console.WriteLine($"{distance_km:f2}");
           
        }
    }
}

