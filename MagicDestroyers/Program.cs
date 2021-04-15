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

            Character warrior = new Warrior("WarriorDude");
            Character knight = new Knight("KnightDude");
            Character mage = new Mage("MageDude");
            Character assasin = new Assassin("AssasinDude");
            Character druid = new Druid("DruidDudess");
            Character necromancer = new Necromancer();

            Mage Lena = new("Lena");
            Warrior Sam = new("Sam", -3, 120);

            List<Character> meeleTeam = new();
            List<Character> spellTeam = new();

            // No access to Meele / Spellcaster methods
            meeleTeam.Add(warrior);
            meeleTeam.Add(knight);
            meeleTeam.Add(assasin);

            spellTeam.Add(druid);
            spellTeam.Add(mage);
            spellTeam.Add(necromancer);

            foreach (var charchter in spellTeam)
            {
                charchter.Attack();
            }

        }
    }
}
