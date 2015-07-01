namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Concrete
{
    using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractPotions;
    using Еscape_from_the_labyrinth_of_death.Interfaces;
    class SmallIntelligencePotion : IntelligencePotion
    {
        private const byte bonusToHealth = 0;
        private const byte bonusToDefense = 0;
        private const byte bonusToAttack = 0;
        private const byte bonusToIntelligence = 8;
        private string itemName;
        private const ItemClass itemClass = ItemClass.Potion;
        private const IntelligencePotionType intelligencePotionType = IntelligencePotionType.Small;

        public SmallIntelligencePotion(string name = "Small Intelligence Potion")
            : base(bonusToHealth, bonusToDefense, bonusToAttack, bonusToIntelligence, name, itemClass, intelligencePotionType)
        {
            this.itemName = name;
        }

    }
}
