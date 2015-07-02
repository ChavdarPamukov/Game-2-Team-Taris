using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.ArmorTypes;
using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractArmors;
using Еscape_from_the_labyrinth_of_death.Interfaces;

namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Concrete
{
    public class UniqueRingMail : RingMail
    {
        private const string name = "Unique Ring Mail";
        private const byte bonusToHealth = 0;
        private const byte bonusToDefense = 35;
        private const byte bonusToAttack = 0;
        private const byte bonusToIntelligence = 0;
        private const ItemClass itemClass = ItemClass.Armor;
        private const RingMailType ringMailType = RingMailType.Unique;

        public UniqueRingMail()
            : base(bonusToHealth, bonusToDefense, bonusToAttack, bonusToIntelligence, name, itemClass, ringMailType)
        {
        }

    }
}
