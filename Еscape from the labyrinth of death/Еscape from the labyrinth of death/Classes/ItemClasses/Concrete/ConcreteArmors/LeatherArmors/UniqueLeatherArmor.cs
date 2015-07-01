namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Concrete
{
    using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractArmors;
    using Еscape_from_the_labyrinth_of_death.Interfaces;
    class UniqueLeatherArmor : LeatherArmor
    {
        private const byte bonusToHealth = 0;
        private const byte bonusToDefense = 30;
        private const byte bonusToAttack = 0;
        private const byte bonusToIntelligence = 0;
        private string itemName;
        private const ItemClass itemClass = ItemClass.Armor;
        private const LeatherArmorType leatherArmorType = LeatherArmorType.Unique;

        public UniqueLeatherArmor(string name)
            : base(bonusToHealth, bonusToDefense, bonusToAttack, bonusToIntelligence, name, itemClass, leatherArmorType)
        {
            this.itemName = name;
        }

    }
}
