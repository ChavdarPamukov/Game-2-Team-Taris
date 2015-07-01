using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.ShieldTypes;
using Еscape_from_the_labyrinth_of_death.Interfaces;

namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.GenericItems
{
    abstract class GenericShield : Item
    {
        private const ItemClass itemClass = ItemClass.Shield;
        private ShieldType shieldType;
        public ShieldType ShieldType
        {
            get { return this.shieldType; }
        }
        public GenericShield(byte healthBonus,
            byte attackBonus,
            byte defenseBonus,
            byte intelligenceBonus,
            string itemName,
            ShieldType shieldType)

            : base(healthBonus, attackBonus, defenseBonus, intelligenceBonus, itemClass, itemName)
        {
            this.shieldType = shieldType;
        }
    }
}
