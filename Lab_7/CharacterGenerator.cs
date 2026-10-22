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

        public Character Generate()
        {
            Character c = new Character();
            c.Name = _names[_random.Next(_names.Count)];
            c.Strength = _random.Next(1, 11);
            c.Speed = _random.Next(1, 11);
            c.Health = _random.Next(50, 101);
            c.SpecialAbility = _abilities[_random.Next(_abilities.Count)];
            return c;
        }
    }
}