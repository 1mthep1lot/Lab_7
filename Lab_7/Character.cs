using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_7
{
    public class Character
    {
        public string Name { get; set; } = "";
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int Health { get; set; }
        public string SpecialAbility { get; set; } = "";

        public override string ToString()
        {
            return $"{Name} Strength:{Strength,3}  Speed:{Speed,3}  HP:{Health,4}  Special: {SpecialAbility}";
        }
    }
}
