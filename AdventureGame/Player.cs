using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    public class Player : Character
    {
        // Counter für die Anzahl der Potions im Inventar
        public int PotionCount { get; set; } = 0;

        // Potionliste als Inventar
        List<Item> items = new List<Item>();

        public Player(string name, int maxHealth=100, int strength=5, int defense=8, int ressistance=3, int intelligence=10) 
            : base(name, maxHealth, strength, defense, ressistance, intelligence)
        {
            this.Name = name;
            this.Health = maxHealth;
            this.MaxHealth = maxHealth;
            this.Strength = strength;
            this.Defense = defense;
            this.Ressistance = ressistance;
            this.Intelligence = intelligence;

            // Startinventar (Potions) definieren
            items.Add(new Item());
            PotionCount += 1;
            items.Add(new Item());
            PotionCount += 1;
            items.Add(new Item()); 
            PotionCount += 1;
            
        }

        public override string ToString()
        {
            return $"\nPlayer - {Name}\nHealth: {Health}\nStrength: {Strength}\nDefense: {Defense}\n" +
                   $"Ressistance: {Ressistance}\nIntelligence: {Intelligence}\nPotions: {PotionCount}\n";
        }

        public void UseItem()
        {
            if (items.Count == 0)
            {
                Console.WriteLine($"\n{Name} has no items to use.\n");

            }
            else
            {
                Item item = items[0];
                items.RemoveAt(0);
                PotionCount--;

                // Apply the item's effect to the player
                item.useOn(this);
                Console.WriteLine($"\n{Name} uses {item.Name} ( {item.type} ).\nRemaining potions: {PotionCount}.\nNew Health: {Health}\n\n");

            }
        }

        public void AddItem(Item item)
        {
            items.Add(item);
            PotionCount++;
            Console.WriteLine($"\n{Name} added {item.Name} ( {item.type} ) to inventory.\nTotal potions: {PotionCount}.\n\n");
        }
    }
}
