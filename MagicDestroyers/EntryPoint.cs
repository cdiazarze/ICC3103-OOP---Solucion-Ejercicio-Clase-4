using MagicDestroyers.Characters;
using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Characters.Spellcasters;
using System.Collections.Generic;

namespace MagicDestroyers
{
    class EntryPoint
    {
        static void Main()
        { 
            List<Character> characters = new List<Character>()
            {
                new Warrior("Phil", 80),
                new Knight(),
                new Assassin(),
                new Druid(),
                new Mage(),
                new Necromancer(),
            };

            foreach (Character character in characters)
            {
                System.Console.WriteLine($"Character: {character.GetType().Name}");
                character.Attack();
                character.SpecialAttack();
                character.Defend();
                System.Console.WriteLine($"Armor: {character.BodyArmor.GetType().Name}");
                character.BodyArmor.Defend();
                System.Console.WriteLine($"Weapon: {character.Weapon.GetType().Name}");
                character.Weapon.Attack();
                character.Weapon.SpecialAttack();

            }


        }
    }
}
