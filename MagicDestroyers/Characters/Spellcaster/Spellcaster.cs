namespace MagicDestroyers.Characters.Spellcaster
{
    public abstract class Spellcaster : Character
    {

        public Spellcaster()
            : base()
        {
        }

        public Spellcaster(string name)
            : base(name)
        {
            System.Console.WriteLine("'Spellcaster' class sub-level-1 constructor");
        }
    }
}
