using Strategy_After.Domain;

namespace Strategy_After.Test
{
    public static class Mother
    {

        public static Character CreateCharacter_Human()
        {
            return new Character()
            {
                //Race = Character.RaceOptions.Human
            };
        }

        public static Character CreateCharacter_Elf()
        {
            return new Character()
            {
                //Race = Character.RaceOptions.Elf
            };
        }

        public static Character CreateCharacter_Dwarf()
        {
            return new Character()
            {
                //Race = Character.RaceOptions.Dwarf
            };
        }

       
    }
}