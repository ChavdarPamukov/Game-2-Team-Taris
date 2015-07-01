using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.ArmorTypes;
using Еscape_from_the_labyrinth_of_death.Interfaces;
using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.GenericItems;

namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractArmors
{
    abstract class RingMail : GenericArmor
    {
        private const ArmorType armorType = ArmorType.RingMail;
        private RingMailType ringMailType;

        public RingMailType RingMailType
        {
            get { return this.ringMailType; }
        }

        public RingMail(byte healthBonus,
            byte defenseBonus,
            byte attackBonus,
            byte intelligenceBonus,
            string itemName,
            ItemClass itemClass,
            RingMailType ringMailType)
            : base(healthBonus, attackBonus, defenseBonus, intelligenceBonus, itemName, armorType)
        {
            this.ringMailType = ringMailType;
        }
    }
}