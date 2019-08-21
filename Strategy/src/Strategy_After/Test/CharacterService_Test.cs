using NUnit.Framework;
using Strategy_After.Domain.CharacterService;

namespace Strategy_After.Test
{
    public class CharacterService_Test
    {
        [Test]
        public void Human_HitPoints_ShouldBe10()
        {
            var strategy = new HumanBaseHitPointsStrategy();
            var characterService = new BaseHitPointsService(strategy);
            var cha = Mother.CreateCharacter_Human();
            var hp = characterService.GetBaseHitPoints(cha);
            Assert.AreEqual(10, hp);
        }

        [Test]
        public void Elf_HitPoints_ShouldBe8()
        {
            var strategy = new ElfBaseHitPointsStrategy();
            var characterService = new BaseHitPointsService(strategy);
            var cha = Mother.CreateCharacter_Elf();
            var hp = characterService.GetBaseHitPoints(cha);
            Assert.AreEqual(8, hp);
        }

        [Test]
        public void Dwarf_HitPoints_ShouldBe12()
        {
            var strategy = new DwarfBaseHitPointsStrategy();
            var characterService = new BaseHitPointsService(strategy);
            var cha = Mother.CreateCharacter_Dwarf();
            var hp = characterService.GetBaseHitPoints(cha);
            Assert.AreEqual(12, hp);
        }

    }
    
}