using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.PotionTypes;
using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractPotions;
using Еscape_from_the_labyrinth_of_death.Interfaces;

namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Concrete
{
    public class LargeHealthPotion : HealthPotion
    {
        private const string name = "Large Health Potion";
        private const byte bonusToHealth = 16;
        private const byte bonusToDefense = 0;
        private const byte bonusToAttack = 0;
        private const byte bonusToIntelligence = 0;
        private const ItemClass itemClass = ItemClass.Potion;
        private const HealthPotionType healthPotionType = HealthPotionType.Large;

        public LargeHealthPotion()
            : base(bonusToHealth, bonusToDefense, bonusToAttack, bonusToIntelligence, name, itemClass, healthPotionType)
        {
        }

    }
}
