using MagicDestroyers.Characters.Enumerations;

namespace MagicDestroyers.Characters.Melee
{
    public abstract class Meele : Character
    {

        protected const int DEFAULT_LEVEL = 1;
        protected const int DEFAULT_HEALTH_POINTS = 100;
        protected const Faction DEFAULT_FACTION = Faction.Melee;
        protected const int DEFAULT_ABILITY_POINTS = 10;

        public Meele(string name)
            : base(name)
        {
            base.Faction = DEFAULT_FACTION;
            System.Console.WriteLine("'Meeele' class sub-level-1 constructor");
        }
    }
}
