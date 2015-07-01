namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Concrete
{
    using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractPotions;
    using Еscape_from_the_labyrinth_of_death.Interfaces;
    class LargeHealthPotion : HealthPotion
    {
        private const byte bonusToHealth = 16;
        private const byte bonusToDefense = 0;
        private const byte bonusToAttack = 0;
        private const byte bonusToIntelligence = 0;
        private string itemName;
        private const ItemClass itemClass = ItemClass.Potion;
        private const HealthPotionType healthPotionType = HealthPotionType.Large;

        public LargeHealthPotion(string name = "Large Health Potion")
            : base(bonusToHealth, bonusToDefense, bonusToAttack, bonusToIntelligence, name, itemClass, healthPotionType)
        {
            this.itemName = name;
        }

    }
}
