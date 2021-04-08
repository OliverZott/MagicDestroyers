using MagicDestroyers.Armors.Mail;
using MagicDestroyers.Weapons.Blunt;

namespace MagicDestroyers.Characters.Melee
{
    class Knight
    {

        private int abilityPoints;
        private string faction;
        private int healthPoints;
        private int level;
        private string name;
        private ChainLink bodyArmor;
        private Hammer weapon;

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
        public Hammer Weapon
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


        public Knight()
        {

        }

        public void HolyBlow()
        {

        }

        public void PurifySoul()
        {

        }

        public void RighteousWings()
        {

        }


    }
}
