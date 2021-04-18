using MagicDestroyers.Characters.Enumerations;

namespace MagicDestroyers
{
    public static class Consts
    {

        public static class Warrior
        {
            public const Faction FACTION = Faction.Melee;
            public const int LEVEL = 1;
            public const int HEALTH_POINTS = 100;
            public const int ABILITY_POINTS = 15;
            public const string NAME = "Bob";
        }

        public static class Mage
        {
            public const Faction FACTION = Faction.Spellcaster;
            public const int LEVEL = 1;
            public const int HEALTH_POINTS = 90;
            public const int ABILITY_POINTS = 20;
            public const string NAME = "Luna";
        }

    }
}
