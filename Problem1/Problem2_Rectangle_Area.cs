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
           
			// Calculate the area of a rectangle with sides: first and second read from the console
			
            var first_side = double.Parse(Console.ReadLine());
            var second = double.Parse(Console.ReadLine());
            
			// sum is the calculated area of the rectangle
			double sum = first_side * second;
			
            Console.WriteLine($"{sum:f2}");
           
        }
    }
}
