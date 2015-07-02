using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.PotionTypes;
using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractPotions;
using Еscape_from_the_labyrinth_of_death.Interfaces;

namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Concrete
{
    public class SmallIntelligencePotion : IntelligencePotion
    {
        private const string name = "Small Intelligence Potion";
        private const byte bonusToHealth = 0;
        private const byte bonusToDefense = 0;
        private const byte bonusToAttack = 0;
        private const byte bonusToIntelligence = 8;
        private const ItemClass itemClass = ItemClass.Potion;
        private const IntelligencePotionType intelligencePotionType = IntelligencePotionType.Small;

        public SmallIntelligencePotion()
            : base(bonusToHealth, bonusToDefense, bonusToAttack, bonusToIntelligence, name, itemClass, intelligencePotionType)
        {
        }

    }
}
