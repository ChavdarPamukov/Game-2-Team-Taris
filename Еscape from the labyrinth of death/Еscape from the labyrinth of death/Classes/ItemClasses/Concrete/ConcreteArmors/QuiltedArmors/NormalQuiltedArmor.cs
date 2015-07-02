using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.ArmorTypes;
using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractArmors;
using Еscape_from_the_labyrinth_of_death.Interfaces;

namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Concrete
{
    public class NormalQuiltedArmor : QuiltedArmor
    {
        private const string name = "Normal Quilted Armor";
        private const byte bonusToHealth = 0;
        private const byte bonusToDefense = 10;
        private const byte bonusToAttack = 0;
        private const byte bonusToIntelligence = 0;
        private const ItemClass itemClass = ItemClass.Armor;
        private const QuiltedArmorType quiltedArmorType = QuiltedArmorType.Normal;

        public NormalQuiltedArmor()
            : base(bonusToHealth, bonusToDefense, bonusToAttack, bonusToIntelligence, name, quiltedArmorType)
        {
        }

    }
}
