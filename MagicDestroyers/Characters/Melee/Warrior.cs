using MagicDestroyers.Armors.Mail;
using MagicDestroyers.Characters.Enumerations;
using MagicDestroyers.Weapons.Sharp;

namespace MagicDestroyers.Characters.Melee
{
    class Warrior
    {
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 1;
        private const Faction DEFAULT_FACTION = Faction.Melee;
        private const int DEFAULT_ABILITY_POINTS = 10;

        private int abilityPoints;
        private Faction faction;
        private int healthPoints;
        private int level;
        private string name;
        private ChainLink bodyArmor;
        private Axe weapon;

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
                    this.Level = 1;         // HAHAHAAH mistake... calls property one more time! 
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
        public ChainLink BodyArmor
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
        public Axe Weapon
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


        public Warrior(string name)
            : this(name, DEFAULT_LEVEL)
        {

        }

        public Warrior(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)  
        {
        }

        public Warrior(string name, int level, int healtPoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healtPoints;
            this.weapon = new Axe();
            this.BodyArmor = new ChainLink();
            this.Faction = DEFAULT_FACTION;
            this.AbilityPoints = DEFAULT_ABILITY_POINTS;
        }

        public override string ToString()
        {
            return base.ToString() + $" --- Weapon: {this.Weapon}, Armor: {this.BodyArmor}";
        }

        public void Execute()
        {

        }

        public void SkinHarden()
        {

        }

        public void Strike()
        {

        }

    }
}
