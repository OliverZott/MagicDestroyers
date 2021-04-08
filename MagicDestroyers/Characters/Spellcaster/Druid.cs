using MagicDestroyers.Armors.Leather;
using MagicDestroyers.Weapons.Blunt;

namespace MagicDestroyers.Characters.Spellcaster
{
    class Druid
    {

        private int abilityPoints;
        private string faction;
        private int healthPoints;
        private int level;
        private string name;
        private LeatherVest bodyArmor;
        private Staff weapon;



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

        public string Faction
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
                healthPoints = value;
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
                level = value;
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

        public LeatherVest BodyArmor
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
        public Staff Weapon
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


        public Druid()
        {

        }

        public void Moonfire()
        {

        }

        public void OneWithNature()
        {

        }

        public void Starburst()
        {

        }

    }
}
