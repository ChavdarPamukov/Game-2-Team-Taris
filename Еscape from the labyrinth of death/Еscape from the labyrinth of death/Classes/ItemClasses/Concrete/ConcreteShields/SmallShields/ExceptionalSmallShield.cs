using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.ShieldTypes;
using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractShields;
using Еscape_from_the_labyrinth_of_death.Interfaces;

namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Concrete
{
    public class ExceptionalSmallShield : SmallShield
    {
        private const string name = "Exceptional Small Shield";
        private const byte bonusToHealth = 0;
        private const byte bonusToDefense = 18;
        private const byte bonusToAttack = 0;
        private const byte bonusToIntelligence = 0;
        private const ItemClass itemClass = ItemClass.Shield;
        private const SmallShieldType smallShieldType = SmallShieldType.Exceptional;

        public ExceptionalSmallShield()
            : base(bonusToHealth, bonusToDefense, bonusToAttack, bonusToIntelligence, name, itemClass, smallShieldType)
        {
        }

    }
}
