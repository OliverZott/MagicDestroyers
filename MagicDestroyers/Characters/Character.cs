using MagicDestroyers.Armors;
using MagicDestroyers.Characters.Enumerations;
using MagicDestroyers.Characters.Interfaces;
using MagicDestroyers.Weapons;

namespace MagicDestroyers.Characters
{
    public abstract class Character : IAttack, IDefend
    {

        private Armor bodyArmor;
        private Faction faction;
        private Weapon weapon;

        private int abilityPoints;
        private int healthPoints;
        private bool isAlive;
        private int level;
        private string name;
        private int scores;


        // use protected if needed empty constructor on base class
        protected Character()
        {
        }

        public Character(string name)
        {
            this.Name = name;
            System.Console.WriteLine("'Character' class base constructor");
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
                else if (value <= 0)
                {
                    this.IsAlive = false;
                }
                else
                {
                    throw new System.ArgumentException("Invalid input (range is 1-500");
                }
            }
        }
        public bool IsAlive
        {
            get { return this.isAlive; }
            protected set { this.isAlive = value; }
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
        public int Scores
        {
            get { return this.scores; }
            private set { this.scores = value; }
        }


        public abstract int Attack();

        public abstract int SpecialAttack();

        public abstract int Defend();

        public void TakeDamage(int damage, string attackerName)
        {
            if (this.Defend() < damage)
            {
                this.HealthPoints -= damage + this.Defend();
            }
            else
            {
                System.Console.WriteLine("MUAHAHAAH, too much defense for your puny attack =)");
            }

            if (this.isAlive)
            {
                System.Console.WriteLine($"{this.name} took {damage} damage from {attackerName}, blocked {this.Defend()} and now has {this.HealthPoints} Health");
            }
            else
            {
                System.Console.WriteLine($"{this.name} took {damage} damage from {attackerName} and is now dead =( ");
            }

        }

        public void WonBattle()
        {
            this.scores++;

            if (this.scores % 10 == 0)
            {
                this.level++;
            }
        }

    }
}
