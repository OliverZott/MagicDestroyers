using MagicDestroyers.Armors.Cloth;
using MagicDestroyers.Weapons.Blunt;

namespace MagicDestroyers.Characters.Spellcaster
{
    class Mage : Spellcaster
    {

        public Mage(string name)
            : this(name, DEFAULT_LEVEL)
        {
        }

        public Mage(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {
        }

        public Mage(string name, int level, int healtPoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healtPoints;
            this.Weapon = new Axe();
            this.BodyArmor = new ChainLink();
            this.Faction = DEFAULT_FACTION;
            this.AbilityPoints = DEFAULT_ABILITY_POINTS;
        }

        public void ArcaneWrath()
        {

        }

        public void Firewall()
        {

        }

        public void Meditaton()
        {

        }


    }
}
