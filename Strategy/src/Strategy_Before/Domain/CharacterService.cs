using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy_Before.Domain
{
    public class CharacterService
    {
        public int GetBaseHitPoints(Character cha)
        {
            switch (cha.Race)
            {
                case Character.RaceOptions.Human:
                    return GetBaseHumanHitPoints(cha);
                case Character.RaceOptions.Elf:
                    return GetBaseElfHitPoints(cha);
                case Character.RaceOptions.Dwarf:
                    return GetBaseDwarfHitPoints(cha);
                default:
                    throw new UnknownCharacterRace();
            }
        }

        int GetBaseHumanHitPoints(Character cha)
        {
            return cha.HitPoints;
        }
        int GetBaseElfHitPoints(Character cha)
        {
            return cha.HitPoints-2;
        }
        int GetBaseDwarfHitPoints(Character cha)
        {
            return cha.HitPoints +2;
        }
    }

}
