using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_7
{
    public class CharacterGenerator
    {

        //One Random Object that is reused everytime we need a random number.
        private Random _random = new Random();

        //Lists of possible names and abilities to pick from. Also easy to extend.
        private List<string> _names = new List<string> { "Leia", "John", "Björn", "Squeek", "Tom" };
        private List<string> _abilities = new List<string> { "Invisibility", "Healing", "DoubleEXP", "Flying", "Strength" };

        public Character Generate()
        {
            Character c = new Character();
            //Picks a random position in the list.
            c.Name = _names[_random.Next(_names.Count)];
            //Next 1,11 gives 1-10.
            c.Strength = _random.Next(1, 11);
            c.Speed = _random.Next(1, 11);
            c.Health = _random.Next(50, 101);
            c.SpecialAbility = _abilities[_random.Next(_abilities.Count)];
            return c; //send the finished character back to whoever called Generate().
        }
    }
}