using MagicDestroyers.Characters;
using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Characters.Spellcaster;
using System.Collections.Generic;

namespace MagicDestroyers
{
    class Program
    {
        static void Main()
        {

            bool gameOver = false;

            List<Character> characters = new()
            {
                new Warrior(),
                new Warrior(),
                new Warrior(),
                //new Assassin(),
                //new Knight(),
                new Mage(),
                new Mage(),
                //new Druid(),
                //new Necromancer()
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

            while (!gameOver)
            {

                // 1. Take a random melee
                // 2. Take a random spellcaster

                spellTeam[0].TakeDamage(meeleTeam[0].Attack(), meeleTeam[0].Name);

                // 3. Melee attacks spellcaster
                // 3.1 Check if melee died and remove in case
                // 3.2 Take new from team

                meeleTeam[0].TakeDamage(spellTeam[0].Attack(), spellTeam[0].Name);
                // 4. Spellcaster attacks melee
                // 4.1 Check if char died and remove in case
                // 4.2 Take new from team

                // 5. If no chars from either team left --> game is finished

            }


        }
    }
}
