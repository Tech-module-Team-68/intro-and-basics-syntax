using System;

namespace P5_Character_Stats
{
    class Character_Stats
    {
        static void Main(string[] args)
        {
            string characterName = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maximumHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {characterName}");
            Console.WriteLine("Health: |" + new string('|', currentHealth) + new string('.', maximumHealth - currentHealth) + '|');
            Console.WriteLine("Energy: |" + new string('|', currentEnergy) + new string('.', maximumEnergy - currentEnergy) + '|');
        }
    }
}
