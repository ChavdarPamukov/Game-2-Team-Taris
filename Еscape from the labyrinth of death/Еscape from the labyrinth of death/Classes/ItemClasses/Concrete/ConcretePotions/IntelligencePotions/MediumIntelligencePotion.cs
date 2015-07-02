using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.PotionTypes;
using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractPotions;
using Еscape_from_the_labyrinth_of_death.Interfaces;

namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Concrete
{
    public class MediumIntelligencePotion : IntelligencePotion
    {
        private const string name = "Medium Intelligence Potion";
        private const byte bonusToHealth = 0;
        private const byte bonusToDefense = 0;
        private const byte bonusToAttack = 0;
        private const byte bonusToIntelligence = 12;
        private const ItemClass itemClass = ItemClass.Potion;
        private const IntelligencePotionType intelligencePotionType = IntelligencePotionType.Medium;

        public MediumIntelligencePotion()
            : base(bonusToHealth, bonusToDefense, bonusToAttack, bonusToIntelligence, name, itemClass, intelligencePotionType)
        {
        }

    }
}
