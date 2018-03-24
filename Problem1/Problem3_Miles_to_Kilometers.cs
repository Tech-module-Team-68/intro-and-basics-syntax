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
			
            var miles = double.Parse(Console.ReadLine()); // miles
           
            double distance_km = miles * 1.60934; // kilometers
			
            Console.WriteLine($"{distance_km:f2}");
           
        }
    }
}

