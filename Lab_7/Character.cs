using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_7
{
    public class Character
    {
        //Properties, the traits the assignment asked for.
        public string Name { get; set; } = "";
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int Health { get; set; }
        public string SpecialAbility { get; set; } = "";

        // controls how a character looks when printed with CW and the formatting is in one piece.
        public override string ToString()
        {
            return $"{Name} Strength:{Strength,3}  Speed:{Speed,3}  HP:{Health,4}  Special: {SpecialAbility}";
        }
    }
}
