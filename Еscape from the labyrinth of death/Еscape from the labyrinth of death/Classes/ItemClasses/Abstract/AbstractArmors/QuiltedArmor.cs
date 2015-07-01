using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.ArmorTypes;
using Еscape_from_the_labyrinth_of_death.Interfaces;
using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.GenericItems;

namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractArmors
{
    abstract class QuiltedArmor : GenericArmor
    {
        private const ArmorType armorType = ArmorType.QuiltedArmor;
        private QuiltedArmorType quiltedArmorType;

        public QuiltedArmorType QuiltedArmorType
        {
            get { return this.quiltedArmorType; }
        }

        public QuiltedArmor(byte healthBonus,
            byte defenseBonus,
            byte attackBonus,
            byte intelligenceBonus,
            string itemName,
            QuiltedArmorType quiltedArmorType)
            : base(healthBonus, attackBonus, defenseBonus, intelligenceBonus, itemName, armorType)
        {
            this.quiltedArmorType = quiltedArmorType;
        }
    }
}