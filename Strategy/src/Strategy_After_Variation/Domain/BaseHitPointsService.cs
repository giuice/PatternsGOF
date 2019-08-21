using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_After_Variation.Domain
{
    public class BaseHitPointsService
    {
        public int GetBaseHitPoints(Character cha, Func<Character,int> baseHitPointsStrategy)
        {
            return baseHitPointsStrategy(cha);
        }
    }
}
