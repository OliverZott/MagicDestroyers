namespace MagicDestroyers.Weapons
{
    public abstract class Weapon
    {

        private int damagePoints;

        public int DamagePoints
        {
            get { return damagePoints; }
            set { damagePoints = value; }
        }

    }
}
