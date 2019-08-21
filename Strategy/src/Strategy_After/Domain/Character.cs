using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy_After.Domain
{
    public class Character
    {
        private int hitPoints = 10;
        //public enum RaceOptions
        //{
        //    Human,
        //    Elf,
        //    Dwarf
        //}

        //public RaceOptions Race { get; set; }
        public int HitPoints { get => hitPoints; set => hitPoints = value; }
    }
}
