using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.PotionTypes;
using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractPotions;
using Еscape_from_the_labyrinth_of_death.Interfaces;

namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Concrete
{
    public class SmallHealthPotion : HealthPotion
    {
        private const string name = "Small Health Potion";
        private const byte bonusToHealth = 8;
        private const byte bonusToDefense = 0;
        private const byte bonusToAttack = 0;
        private const byte bonusToIntelligence = 0;
        private const ItemClass itemClass = ItemClass.Potion;
        private const HealthPotionType healthPotionType = HealthPotionType.Small;

        public SmallHealthPotion()
            : base(bonusToHealth, bonusToDefense, bonusToAttack, bonusToIntelligence, name, itemClass, healthPotionType)
        {
        }

    }
}
