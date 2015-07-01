using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.PotionTypes;

namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Concrete
{
    using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractPotions;
    using Еscape_from_the_labyrinth_of_death.Interfaces;
    class MediumHealthPotion : HealthPotion
    {
        private const byte bonusToHealth = 12;
        private const byte bonusToDefense = 0;
        private const byte bonusToAttack = 0;
        private const byte bonusToIntelligence = 0;
        private string itemName;
        private const ItemClass itemClass = ItemClass.Potion;
        private const HealthPotionType healthPotionType = HealthPotionType.Medium;

        public MediumHealthPotion(string name = "Medium Health Potion")
            : base(bonusToHealth, bonusToDefense, bonusToAttack, bonusToIntelligence, name, itemClass, healthPotionType)
        {
            this.itemName = name;
        }

    }
}
