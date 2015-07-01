using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.ArmorTypes;

namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Concrete
{
    using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractArmors;
    using Еscape_from_the_labyrinth_of_death.Interfaces;
    class ExceptionalRingMail : RingMail
    {
        private const byte bonusToHealth = 0;
        private const byte bonusToDefense = 28;
        private const byte bonusToAttack = 0;
        private const byte bonusToIntelligence = 0;
        private string itemName;
        private const ItemClass itemClass = ItemClass.Armor;
        private const RingMailType ringMailType = RingMailType.Exceptional;

        public ExceptionalRingMail(string name)
            : base(bonusToHealth, bonusToDefense, bonusToAttack, bonusToIntelligence, name, itemClass, ringMailType)
        {
            this.itemName = name;
        }

    }
}
