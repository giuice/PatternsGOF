using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_After.Domain.CharacterService
{
    public interface IBaseHitPointsStrategy
    {
        int GetBaseHitPoints(Character cha);
    }
}
