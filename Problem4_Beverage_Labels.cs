using System;

namespace Pr4_Beverage_Labels
{
    class Beverage_Labels
    {
        static void Main(string[] args)
        {
            string beverageName = Console.ReadLine();
            double beverageVolume = int.Parse(Console.ReadLine());
            double energyContentPer100ml = int.Parse(Console.ReadLine());
            double sugarContentPer100ml = int.Parse(Console.ReadLine());

            double beverageEnergy = beverageVolume * energyContentPer100ml / 100;
            double beverageSugar = beverageVolume * sugarContentPer100ml / 100;

            Console.WriteLine($"{beverageVolume}ml {beverageName}:");
            Console.WriteLine($"{beverageEnergy}kcal, {beverageSugar}g sugars");
        }
    }
}
