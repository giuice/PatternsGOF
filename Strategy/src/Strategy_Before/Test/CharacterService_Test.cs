using NUnit.Framework;
using Strategy_Before.Domain;

namespace Strategy_Before.Test
{

    public class CharacterService_Test
    {
        [Test]
        public void Human_HitPoints_ShouldBe10()
        {
            var characterService = new CharacterService();
            var cha = Mother.CreateCharacter_Human();
            var hp = characterService.GetBaseHitPoints(cha);
            Assert.AreEqual(10, hp);
        }

        [Test]
        public void Elf_HitPoints_ShouldBe8()
        {
            var characterService = new CharacterService();
            var cha = Mother.CreateCharacter_Elf();
            var hp = characterService.GetBaseHitPoints(cha);
            Assert.AreEqual(8, hp);
        }

        [Test]
        public void Dwarf_HitPoints_ShouldBe12()
        {
            var characterService = new CharacterService();
            var cha = Mother.CreateCharacter_Dwarf();
            var hp = characterService.GetBaseHitPoints(cha);
            Assert.AreEqual(12, hp);
        }

    }

}