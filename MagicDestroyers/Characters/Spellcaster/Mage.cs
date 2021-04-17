using MagicDestroyers.Armors.Leather;
using MagicDestroyers.Weapons.Sharp;

namespace MagicDestroyers.Characters.Spellcaster
{
    class Mage : Spellcaster
    {

        public Mage()
            : base()
        {
        }

        public Mage(string name)
            : this(name, DEFAULT_LEVEL)
        {
            System.Console.WriteLine("'Mage' class sub-level-1 constructor");
        }

        public Mage(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {
            System.Console.WriteLine("'Mage' class sub-level-2 constructor");
        }

        public Mage(string name, int level, int healtPoints)
            : base(name)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healtPoints;
            this.Weapon = new Sword();
            this.BodyArmor = new LeatherVest();
            this.AbilityPoints = DEFAULT_ABILITY_POINTS;
            System.Console.WriteLine("'Mage' class sub-level-3 constructor");
        }

        public int ArcaneWrath()
        {
            return base.Weapon.DamagePoints + 5;
        }


        public int Firewall()
        {
            return base.Weapon.DamagePoints + 25;
        }

        public int Meditaton()
        {
            return this.BodyArmor.ArmorPoints + 10;                 // this or base ???? 
        }

        public override int Attack()
        {
            return this.ArcaneWrath();
        }

        public override int SpecialAttack()
        {
            return this.Firewall();
        }

        public override int Defend()
        {
            return this.Meditaton();
        }
    }
}
