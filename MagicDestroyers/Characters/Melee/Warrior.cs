using MagicDestroyers.Armors.Mail;
using MagicDestroyers.Weapons.Sharp;

namespace MagicDestroyers.Characters.Melee
{
    class Warrior : Meele
    {

        protected const string DEFAULT_NAME = "WarriorBob";

        public Warrior()
            : this(DEFAULT_NAME)
        {
        }

        public Warrior(string name)
            : this(name, Consts.Warrior.LEVEL)
        {
        }

        public Warrior(string name, int level)
            : this(name, level, Consts.Warrior.HEALTH_POINTS)
        {
        }

        public Warrior(string name, int level, int healtPoints)
            : base(name)
        {
            this.Level = level;
            base.HealthPoints = healtPoints;    // WTF ... no difference ?!
            base.Weapon = new Axe();
            base.BodyArmor = new ChainLink();
            base.AbilityPoints = Consts.Warrior.ABILITY_POINTS;
            base.IsAlive = true;
            base.Level = 1;
        }


        public override string ToString()
        {
            return base.ToString() + $" --- Weapon: {this.Weapon}, Armor: {this.BodyArmor}";
        }


        public int Execute()
        {
            return base.Weapon.DamagePoints + 35;
        }

        public int SkinHarden()
        {
            return base.BodyArmor.ArmorPoints + 15;
        }

        public int Strike()
        {
            return base.Weapon.DamagePoints + 30;
        }

        public override int Attack()
        {
            return this.Strike();
        }

        public override int SpecialAttack()
        {
            return this.Execute();
        }

        public override int Defend()
        {
            return this.SkinHarden();
        }
    }
}
