using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.ArmorTypes;
using Еscape_from_the_labyrinth_of_death.Interfaces;
using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.GenericItems;

namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractArmors
{
    abstract class LeatherArmor : GenericArmor
    {
        private const ArmorType armorType = ArmorType.LeatherArmor;
        private LeatherArmorType leatherArmorType;

        public LeatherArmorType LeatherArmorType
        {
            get { return this.leatherArmorType; }
        }

        public LeatherArmor(byte healthBonus,
            byte defenseBonus,
            byte attackBonus,
            byte intelligenceBonus,
            string itemName,
            LeatherArmorType leatherArmorType)
            : base(healthBonus, attackBonus, defenseBonus, intelligenceBonus, itemName, armorType)
        {
            this.leatherArmorType = leatherArmorType;
        }
    }
}