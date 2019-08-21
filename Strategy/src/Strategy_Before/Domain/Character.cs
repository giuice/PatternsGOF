using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy_Before.Domain
{
    public class Character
    {
        public enum RaceOptions
        {
            Human,
            Elf,
            Dwarf
        }

        public RaceOptions Race { get; set; }
        public int HitPoints { get; set; } = 10;
    }
}
