using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategy_After_Variation.Domain;

namespace Strategy_After_Variation
{
    public class Program
    {

        public static void Main(string[] args)
        {

            Func<Character, int> humanStrategy = GetHumanBaseHitPoints;
            //2 ways to do the same strategy
            Func<Character, int> elfStrategy = delegate (Character cha) { return cha.HitPoints - 2; };
            Func<Character, int> dwarfStrategy = cha => cha.HitPoints + 2;


            Character character = Mother.CreateCharacter();
            
            var baseHitPointsService = new BaseHitPointsService();
            Console.WriteLine("Human hit points: " + baseHitPointsService.GetBaseHitPoints(character, humanStrategy));
            Console.WriteLine("Elf hit points: " + baseHitPointsService.GetBaseHitPoints(character, elfStrategy));
            Console.WriteLine("Dwarf hit points: " + baseHitPointsService.GetBaseHitPoints(character, dwarfStrategy));
            Console.ReadKey();
        }

        private static int GetHumanBaseHitPoints(Character arg)
        {
            return arg.HitPoints;
        }

    }
}
