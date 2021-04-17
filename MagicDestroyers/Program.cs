using MagicDestroyers.Characters;
using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Characters.Spellcaster;
using System.Collections.Generic;

namespace MagicDestroyers
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Character> characters = new()
            {
                new Warrior(),
                new Assassin(),
                new Knight(),
                new Mage(),
                new Druid(),
                new Necromancer()
            };


            List<Meele> meeleTeam = new();
            List<Spellcaster> spellTeam = new();

            foreach (var character in characters)
            {
                if (character is Meele)
                {
                    meeleTeam.Add((Meele)character);
                }
                else if (character is Spellcaster)
                {
                    spellTeam.Add((Spellcaster)character);
                }
            }

        }
    }
}
