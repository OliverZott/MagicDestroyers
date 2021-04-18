namespace MagicDestroyers.Characters.Melee
{
    public abstract class Meele : Character
    {

        public Meele()
            : base()
        {
        }

        public Meele(string name)
            : base(name)
        {
            System.Console.WriteLine("'Meeele' class sub-level-1 constructor");
        }
    }
}
