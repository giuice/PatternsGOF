using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_After.Domain.CharacterService
{
    public class BaseHitPointsService
    {
        readonly IBaseHitPointsStrategy _baseHP;

        public BaseHitPointsService(IBaseHitPointsStrategy baseHP)
        {
            _baseHP = baseHP;
        }

        public int GetBaseHitPoints(Character cha)
        {
            return _baseHP.GetBaseHitPoints(cha);
        }
    }
}
