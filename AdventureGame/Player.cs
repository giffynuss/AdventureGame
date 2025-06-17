using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    internal class Player : Character
    {
        // Counter für die Anzahl der Potions im Inventar
        public int PotionCount { get; set; } = 0;

        // Potionliste als Inventar
        List<Item> items = new List<Item>();

        public Player(string name, int health=100, int strength=5, int defense=8, int ressistance=3, int intelligence=10) 
            : base(name, health, strength, defense, ressistance, intelligence)
        {
            this.Name = name;
            this.Health = health;
            this.Strength = strength;
            this.Defense = defense;
            this.Ressistance = ressistance;
            this.Intelligence = intelligence;

            // Startinventar (Potions) definieren
            /*
            items.Add(new Item("Health Potion", 20, 0, 0, 0, 0));
            PotionCount += 1;
            items.Add(new Item("Health Potion", 20, 0, 0, 0, 0));
            PotionCount += 1;
            items.Add(new Item("Health Potion", 20, 0, 0, 0, 0)); 
            PotionCount += 1;
            */
        }

        public void UseItem(Item item)
        {
            // Implement item usage logic here
            //Console.WriteLine($"{Name} uses {item.Name}.");
            // Example: Increase health, strength, etc. based on the item
            /*
            Health += item.HealthBoost;
            Strength += item.StrengthBoost;
            Defense += item.DefenseBoost;
            Ressistance += item.RessistanceBoost;
            Intelligence += item.IntelligenceBoost;*/
        }

        public void AddItem(Item item)
        {
            /*
            items.Add(item);
            PotionCount++;
            Console.WriteLine($"{Name} added {item.Name} to inventory. Total potions: {PotionCount}.");
            */
        }
    }
}
