using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.ShieldTypes;
using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractShields;
using Еscape_from_the_labyrinth_of_death.Interfaces;

namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Concrete
{
    public class ExceptionalLargeShield : LargeShield
    {
        private const string name = "Exceptional Large Shield";
        private const byte bonusToHealth = 0;
        private const byte bonusToDefense = 23;
        private const byte bonusToAttack = 0;
        private const byte bonusToIntelligence = 0;
        private const ItemClass itemClass = ItemClass.Shield;
        private const LargeShieldType largeShieldType = LargeShieldType.Exceptional;

        public ExceptionalLargeShield()
            : base(bonusToHealth, bonusToDefense, bonusToAttack, bonusToIntelligence, name, itemClass, largeShieldType)
        {
        }

    }
}
