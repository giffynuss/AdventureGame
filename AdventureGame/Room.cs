using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    public class Room
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Item Item { get; set; }
        public Monster Monster { get; set; }
        public Room(Item item, Monster monster, string name = "Feuerraum", string description = "fire baby")
        {
            this.Name = name;
            this.Description = description;
            this.Item = item;
            this.Monster = monster;
        }
        public override string ToString()
        {
            return $"{Name}\n{Description}";
        }
    }
}
