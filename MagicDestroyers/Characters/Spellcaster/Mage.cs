using MagicDestroyers.Armors.Leather;
using MagicDestroyers.Weapons.Sharp;

namespace MagicDestroyers.Characters.Spellcaster
{
    class Mage : Spellcaster
    {

        protected const string DEFAULT_NAME = "MageLilu";

        public Mage()
            : this(DEFAULT_NAME)
        {
        }

        public Mage(string name)
            : this(name, Consts.Mage.LEVEL)
        {
            //System.Console.WriteLine("'Mage' class sub-level-1 constructor");
        }

        public Mage(string name, int level)
            : this(name, level, Consts.Mage.HEALTH_POINTS)
        {
            System.Console.WriteLine("'Mage' class sub-level-2 constructor");
        }

        public Mage(string name, int level, int healtPoints)
            : base(name)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healtPoints;
            base.Weapon = new Sword();
            base.BodyArmor = new LeatherVest();
            base.AbilityPoints = Consts.Mage.ABILITY_POINTS; ;
            base.IsAlive = true;
            base.Level = 1;
            System.Console.WriteLine("'Mage' class sub-level-3 constructor");
        }

        public int ArcaneWrath()
        {
            return base.Weapon.DamagePoints + 35;
        }


        public int Firewall()
        {
            return base.Weapon.DamagePoints + 45;
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
