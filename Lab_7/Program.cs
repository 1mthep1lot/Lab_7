using System;
using System.Collections.Generic;

namespace Lab_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CharacterGenerator generator = new CharacterGenerator();
            List<Character> characters = new List<Character>();

            bool running = true;

            while (running)
            {
                Console.WriteLine();
                Console.WriteLine("1. Create character");
                Console.WriteLine("2. Show all characters");
                Console.WriteLine("3. Exit");
                Console.Write("Choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Character c = generator.Generate();
                        characters.Add(c);
                        Console.WriteLine("Created: " + c);
                        break;
                    case "2":
                        if (characters.Count == 0)
                        {
                            Console.WriteLine("No characters yet.");
                        }
                        foreach (Character ch in characters)
                        {
                            Console.WriteLine(ch);
                        }
                        break;
                    case "3":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}