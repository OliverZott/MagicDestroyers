using MagicDestroyers.Armors.Leather;
using MagicDestroyers.Weapons.Sharp;

namespace MagicDestroyers.Characters.Spellcaster
{
    class Necromancer
    {

        private int abilityPoints;
        private string faction;
        private int healthPoints;
        private int level;
        private string name;
        private LeatherVest bodyArmor;
        private Sword weapon;


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
        public Sword Weapon
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


        public Necromancer()
        {

        }


        public void BoneShiled()
        {

        }

        public void ShadowRage()
        {

        }

        public void VampireTouch()
        {

        }

    }
}
