using System;
using System.Runtime.Serialization;

namespace Strategy_Before.Domain
{
    [Serializable]
    public class UnknownCharacterRace : Exception
    {
        public UnknownCharacterRace()
        {
        }
    }
}