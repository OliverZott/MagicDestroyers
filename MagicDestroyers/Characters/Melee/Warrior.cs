using MagicDestroyers.Armors.Mail;
using MagicDestroyers.Weapons.Sharp;

namespace MagicDestroyers.Characters.Melee
{
    class Warrior : Meele
    {

        public Warrior(string name)
            : this(name, DEFAULT_LEVEL)
        {
        }

        public Warrior(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {
        }

        public Warrior(string name, int level, int healtPoints)
            : base(name)
        {
            this.Level = level;
            this.HealthPoints = healtPoints;
            this.Weapon = new Axe();
            this.BodyArmor = new ChainLink();
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
