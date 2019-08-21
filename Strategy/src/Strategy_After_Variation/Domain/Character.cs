using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_After_Variation.Domain
{
    public class Character
    {
        private int hitPoints = 10;
        public int HitPoints { get => hitPoints; set => hitPoints = value; }
    }
}
