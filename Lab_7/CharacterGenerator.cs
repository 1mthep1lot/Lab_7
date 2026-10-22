using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_7
{
     public class CharacterGenerator
    {
        private Random _random = new Random();

        private List<string> _names = new List<string> { "Leia", "John", "Björn", "Squeek", "Tom" };
        private List<string> _abilities = new List<string> { "Invisibility", "Healing", "DoubleEXP", "Flying", "Strength" };


        public CharacterGenerator Generate() => new()
        {
            Name = Names[_random.Next(Names.Length)],
            Strength = _random.Next(1, 11),
            Speed = _random.Next(1, 11),
            Health = _random.Next(50, 101),
            SpecialAbility = Abilities[_random.Next(Abilities.Length)]
        };
    }
}
