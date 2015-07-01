using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.ArmorTypes;

namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Concrete
{
    using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractArmors;
    using Еscape_from_the_labyrinth_of_death.Interfaces;
    class ExceptionalQuiltedArmor : QuiltedArmor
    {
        private const byte bonusToHealth = 0;
        private const byte bonusToDefense = 17;
        private const byte bonusToAttack = 0;
        private const byte bonusToIntelligence = 0;
        private string itemName;
        private const ItemClass itemClass = ItemClass.Armor;
        private const QuiltedArmorType quiltedArmorType = QuiltedArmorType.Exceptional;

        public ExceptionalQuiltedArmor(string name)
            : base(bonusToHealth, bonusToDefense, bonusToAttack, bonusToIntelligence, name, itemClass, quiltedArmorType)
        {
            this.itemName = name;
        }

    }
}
