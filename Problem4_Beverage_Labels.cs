using System;

namespace Pr4_Beverage_Labels
{
    class Beverage_Labels
    {
        static void Main(string[] args)
        {	
			// we recive from the Console the beverage Name-> a string
            string beverageName = Console.ReadLine();
            // we recive from the Console volume -> a integer
			//we recive from the Console content of energi per 100ml product -> a integer
			//we recive from the Console content of sugar per 100ml product -> a integer
			double beverageVolume = int.Parse(Console.ReadLine());
            double energyContentPer100ml = int.Parse(Console.ReadLine()); 
            double sugarContentPer100ml = int.Parse(Console.ReadLine());
				// we calculate...
            double beverageEnergyLevel = beverageVolume * energyContentPer100ml / 100;
            double beverageSugar = beverageVolume * sugarContentPer100ml / 100;
				//TODO
            Console.WriteLine($"{beverageVolume}ml {beverageName}:");
            Console.WriteLine($"{beverageEnergyLevel}kcal, {beverageSugar}g sugars");
        }
    }
}
