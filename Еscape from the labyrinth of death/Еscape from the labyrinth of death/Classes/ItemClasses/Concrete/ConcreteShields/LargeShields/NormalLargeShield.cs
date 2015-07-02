using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.ShieldTypes;
using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractShields;
using Еscape_from_the_labyrinth_of_death.Interfaces;

namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Concrete
{
    public class NormalLargeShield : LargeShield
    {
        private const string name = "Normal Large Shield";
        private const byte bonusToHealth = 0;
        private const byte bonusToDefense = 17;
        private const byte bonusToAttack = 0;
        private const byte bonusToIntelligence = 0;
        private const ItemClass itemClass = ItemClass.Shield;
        private const LargeShieldType largeShieldType = LargeShieldType.Normal;

        public NormalLargeShield()
            : base(bonusToHealth, bonusToDefense, bonusToAttack, bonusToIntelligence, name, itemClass, largeShieldType)
        {
        }

    }
}
