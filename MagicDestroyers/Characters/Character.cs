using MagicDestroyers.Armors;
using MagicDestroyers.Characters.Enumerations;
using MagicDestroyers.Weapons;

namespace MagicDestroyers.Characters
{
    public class Character
    {
        private int abilityPoints;
        private Faction faction;
        private int healthPoints;
        private int level;
        private string name;
        private Armor bodyArmor;
        private Weapon weapon;

        public Character(string name)
        {
            this.Name = name;
            System.Console.WriteLine("'Character' class base constructor");
        }

        public int AbilityPoints
        {
            get
            {
                return abilityPoints;
            }
            set
            {
                abilityPoints = value;
            }
        }
        public Faction Faction
        {
            get
            {
                return faction;
            }
            set
            {
                faction = value;
            }
        }
        public int HealthPoints
        {
            get
            {
                return healthPoints;
            }
            set
            {
                if (value > 0 && value < 500)
                {
                    healthPoints = value;
                }
                else
                {
                    throw new System.ArgumentException("Invalid input (range is 1-500");
                }
            }
        }
        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                if (value > 0 && value < 100)
                {
                    this.level = value;
                }
                else
                {
                    System.Console.WriteLine("Wrong input: value is set to default (level=1)");
                    this.level = 1;
                }

            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Armor BodyArmor
        {
            get
            {
                return bodyArmor;
            }
            set
            {
                bodyArmor = value;
            }
        }
        public Weapon Weapon
        {
            get
            {
                return weapon;
            }
            set
            {
                weapon = value;
            }
        }
    }
}
