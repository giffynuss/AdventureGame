using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    public class Item
    {

        public string Name { get; set; }
        public string type { get; set; } // Type of item (e.g., "Potion", "Weapon", "Armor")
        public int EffectValue { get; set; }
        public string EffectType { get; set; } // Type of effect (e.g., "Health", "Strength", "Defense")
        public int value { get; set; } // Value of the item (e.g., gold value)

        public Item(string name="Health Potion", string type="Potion", int effectValue=25, string effectType="Health gain", int value=100)
        {
            this.Name = name;
            this.type = type;
            this.EffectValue = effectValue;
            this.EffectType = effectType;
            this.value = value;
        }


        public override string ToString()
        {
            return $"{Name} ( {type} )\nEffect: {EffectValue} {EffectType}\nValue: {value} gold";
        }

        public void useOn(Character target)
        {
            if (target.Health + EffectValue > target.MaxHealth)
            {
                target.Health = target.MaxHealth;
            }
            else
            {
                target.Health += EffectValue;
            }
        }

    }
}
