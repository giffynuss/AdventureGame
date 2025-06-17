using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    internal abstract class Character
    {

        public string Name { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Defense { get; set; }
        public int Ressistance { get; set; }
        public int Intelligence { get; set; }

        public Character(string name, int health, int strength, int defense, int ressistance, int intelligence)
        {
            this.Name = name;
            this.Health = health;
            this.Strength = strength;
            this.Defense = defense;
            this.Ressistance = ressistance;
            this.Intelligence = intelligence;
        }

        public void attackPhysical(Character target)
        {
            target.Health -= Strength - target.Defense;

            Console.WriteLine($"{Name} attacks with strength {Strength}.");
        }

        public void attackMagic(Character target)
        {
            target.Health -= Intelligence - target.Ressistance;

            Console.WriteLine($"{Name} attacks with magic {Intelligence}.");
        }

    }
}
