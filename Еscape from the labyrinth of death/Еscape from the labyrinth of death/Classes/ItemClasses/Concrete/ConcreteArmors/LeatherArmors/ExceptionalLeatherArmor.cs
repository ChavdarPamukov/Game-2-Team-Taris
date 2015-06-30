namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Concrete
{
    using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractArmors;
    using Еscape_from_the_labyrinth_of_death.Interfaces;
    class ExceptionalLeatherArmor : LeatherArmor
    {
        private const byte bonusToHealth = 0;
        private const byte bonusToDefense = 25;
        private const byte bonusToAttack = 0;
        private const byte bonusToIntelligence = 0;
        private string itemName;
        private const ItemClass itemClass = ItemClass.Armor;
        private const LeatherArmorType leatherArmorType = LeatherArmorType.Exceptional;

        public ExceptionalLeatherArmor(string name)
            : base(bonusToHealth, bonusToDefense, bonusToAttack, bonusToIntelligence, name, itemClass, leatherArmorType)
        {
            this.itemName = name;
        }

    }
}
