using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.ShieldTypes;
using Еscape_from_the_labyrinth_of_death.Interfaces;
using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.GenericItems;

namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractShields
{
    public abstract class SmallShield : GenericShield
    {
        private const ShieldType shieldType = ShieldType.SmallShield;
        private SmallShieldType smallShieldType;

        public SmallShieldType SmallShieldType
        {
            get { return this.smallShieldType; }
        }

        public SmallShield(byte healthBonus,
            byte defenseBonus,
            byte attackBonus,
            byte intelligenceBonus,
            string itemName,
            ItemClass itemClass,
            SmallShieldType smallShieldType)
            : base(healthBonus, attackBonus, defenseBonus, intelligenceBonus, itemName, shieldType)
        {
            this.smallShieldType = smallShieldType;
        }
    }
}