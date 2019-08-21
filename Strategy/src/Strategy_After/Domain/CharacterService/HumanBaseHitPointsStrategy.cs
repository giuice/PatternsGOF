using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_After.Domain.CharacterService
{
    public class HumanBaseHitPointsStrategy : IBaseHitPointsStrategy
    {
        public int GetBaseHitPoints(Character cha)
        {
            return cha.HitPoints;
        }
    }
}
