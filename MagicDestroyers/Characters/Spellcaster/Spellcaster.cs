using MagicDestroyers.Characters.Enumerations;

namespace MagicDestroyers.Characters.Spellcaster
{
    public class Spellcaster : Character
    {

        protected const int DEFAULT_LEVEL = 1;
        protected const int DEFAULT_HEALTH_POINTS = 80;
        protected const Faction DEFAULT_FACTION = Faction.Spellcaster;
        protected const int DEFAULT_ABILITY_POINTS = 15;

        public Spellcaster(string name)
            : base(name)
        {
            base.Faction = DEFAULT_FACTION;
            System.Console.WriteLine("'Spellcaster' class sub-level-1 constructor");
        }
    }
}
