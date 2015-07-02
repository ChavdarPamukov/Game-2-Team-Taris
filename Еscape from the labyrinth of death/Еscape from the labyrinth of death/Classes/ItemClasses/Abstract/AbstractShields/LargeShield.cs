using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.ShieldTypes;
using Еscape_from_the_labyrinth_of_death.Interfaces;
using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.GenericItems;

namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractShields
{
    public abstract class LargeShield : GenericShield
    {
        private const ShieldType shieldType = ShieldType.LargeShield;
        private LargeShieldType largeShieldType;

        public LargeShieldType LargeShieldType
        {
            get { return this.largeShieldType; }
        }

        public LargeShield(byte healthBonus,
            byte defenseBonus,
            byte attackBonus,
            byte intelligenceBonus,
            string itemName,
            ItemClass itemClass,
            LargeShieldType largeShieldType)
            : base(healthBonus, attackBonus, defenseBonus, intelligenceBonus, itemName, shieldType)
        {
            this.largeShieldType = largeShieldType;
        }
    }
}