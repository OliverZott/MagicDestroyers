using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Characters.Spellcaster;

namespace MagicDestroyers
{
    class Program
    {
        static void Main(string[] args)
        {

            Mage Lena = new("Lena");
            Warrior Sam = new("Sam", -3, 120);
            System.Console.WriteLine(Sam);

            Warrior Bob = new("Bob");
            System.Console.WriteLine(Bob);

            // ---- Create Classes
            // Warrior, Knight, Druid, Mage, Assassin
            // Axe, Sword, Hammer, Staff
            // ClothRope, LeatherVest, ChainLink

            // --- Create properties in classes

            // abilityPoints, faction, healthPoints, level, name, bodyArmor, weapon
            // armorPoints
            // damagePoints


            // ---- 
            // Warrior -> ChainLink and Axe
            // Knight -> ChainLink and Hammer
            // Assassin -> LeatherVest and Sword
            // Mage -> ClothRope and Staff
            // Necromancer -> LeatherVest and Sword
            // Druid -> LEatherVest and Staff


            // ---- Create methods for all classes
            // Warrior -> Strike, Execute, SkinHarden
            // Assassin -> Raze, Bleed, Survival
            // Knight -> HolyBlow, PurifySoul, RighteousWings 
            // Mage -> ArcanWrath, Firewall, Meditation
            // Necromancer -> ShadowRage, VampireTouch, BoneShield
            // Druid -> Moonfire, Starburst, OnWithNature
            // Sword -> Bloodthirst
            // Axe -> HackNSlash
            // Hammer -> Stung
            // Staff -> Empower


            // ---- Add One empty constructor to each class (functions for weapons): 


            // ---- Create Folder Structure:
            // Weapons  - Sharp - Axe
            //                  - Sword
            //          - Blunt - Hammer
            //                  - Staff
            // ...
            // ...


            // ---- Use "this" keyword for fields everywhere


            // ---- Constructor
            // arguments (name, level, healthPoints) 
            // rest of fields are default values in constructor

            // ---- Use various Constructors
            // Default constructor
            // name, level
            // name, level, abilityPoints


        }
    }
}
