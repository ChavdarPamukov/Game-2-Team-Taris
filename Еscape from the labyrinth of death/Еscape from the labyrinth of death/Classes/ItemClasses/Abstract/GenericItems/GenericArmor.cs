using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.ArmorTypes;
using Еscape_from_the_labyrinth_of_death.Interfaces;

namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.GenericItems
{
    abstract class GenericArmor : Item
    {
        private const ItemClass itemClass = ItemClass.Armor;
        private ArmorType armorType;
        public ArmorType ArmorType
        {
            get { return this.armorType; }
        }
        public GenericArmor(byte healthBonus,
            byte attackBonus,
            byte defenseBonus,
            byte intelligenceBonus,
            string itemName,
            ArmorType armorType)

            : base(healthBonus, attackBonus, defenseBonus, intelligenceBonus, ItemClass.Armor, itemName)
        {
            this.armorType = armorType;
        }
    }
}
