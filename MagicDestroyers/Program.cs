using MagicDestroyers.Characters;
using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Characters.Spellcaster;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicDestroyers
{
    class Program
    {
        static void Main()
        {

            bool gameOver = false;

            Random rng = new Random();
            Meele currentMeele;
            Spellcaster currentSpellcaster;

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
            // meeleTeam = characters.OfType<Meele>().ToList();
            meeleTeam = characters.Where(c => c is Meele).Cast<Meele>().ToList();

            List<Spellcaster> spellTeam = characters.OfType<Spellcaster>().ToList();


            /*
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
            */

            while (!gameOver)
            {

                currentMeele = meeleTeam[rng.Next(0, meeleTeam.Count)];
                currentSpellcaster = spellTeam[rng.Next(0, spellTeam.Count)];


                currentSpellcaster.TakeDamage(currentMeele.Attack(), currentMeele.Name);

                if (!currentSpellcaster.IsAlive)
                {
                    currentMeele.WonBattle();
                    spellTeam.Remove(currentSpellcaster);

                    if (spellTeam.Count == 0)
                    {
                        Console.WriteLine("Meele Team wins, no more SpellCasters left!");
                        break;
                    }
                    else
                    {
                        currentSpellcaster = spellTeam[rng.Next(0, spellTeam.Count)]; ;
                    }
                }


                currentMeele.TakeDamage(currentSpellcaster.Attack(), currentSpellcaster.Name);

                if (!currentMeele.IsAlive)
                {
                    currentSpellcaster.WonBattle();
                    meeleTeam.Remove(currentMeele);

                    if (meeleTeam.Count == 0)
                    {
                        Console.WriteLine("SpellCaster Team wins, no more SpellCasters left!");
                        break;
                    }
                    else
                    {
                        currentMeele = meeleTeam[rng.Next(0, meeleTeam.Count)];
                    }
                }

            }


        }
    }
}
