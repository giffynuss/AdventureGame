using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    internal class Monster : Character
    {

        public string Type { get; set; }
        public string Title { get; set; }

        public Monster(string name, int maxHealth=20, int strength = 2, int defense = 1, int ressistance = 0, 
            int intelligence = 2, string type = "Monster", string title = "Vanguard")
            : base(name, maxHealth, strength, defense, ressistance, intelligence)
        {
            this.Name = name;
            this.Health = maxHealth;
            this.MaxHealth = maxHealth;
            this.Strength = strength;
            this.Defense = defense;
            this.Ressistance = ressistance;
            this.Intelligence = intelligence;
            this.Type = type;
            this.Title = title;
        }

        public override string ToString()
        {
            return $"\n{Title} - {Name} ( {Type} )\nHealth: {Health}\nStrength: {Strength}\nDefense: {Defense}\n" +
                   $"Ressistance: {Ressistance}\nIntelligence: {Intelligence}\n";
        }

    }
}
