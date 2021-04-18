using System;

namespace MagicDestroyers
{
    public class Tools
    {

        public static void ColorfulWriteLine(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void TypeColorMessage(string message, string type)
        {
            ConsoleColor color = ConsoleColor.White;

            switch (type)
            {
                case "MagicDestroyers.Characters.Melee.Warrior":
                    color = ConsoleColor.Blue;
                    break;
                case "MagicDestroyers.Characters.Spellcaster.Mage":
                    color = ConsoleColor.Red;
                    break;
            }

            ColorfulWriteLine(message, color);
        }
    }
}
