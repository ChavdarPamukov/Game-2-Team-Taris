namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Concrete
{
    using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractShields;
    using Еscape_from_the_labyrinth_of_death.Interfaces;
    class UniqueBoneShield : BoneShield
    {
        private const byte bonusToHealth = 0;
        private const byte bonusToDefense = 24;
        private const byte bonusToAttack = 0;
        private const byte bonusToIntelligence = 0;
        private string itemName;
        private const ItemClass itemClass = ItemClass.Shield;
        private const BoneShieldType boneShieldType = BoneShieldType.Unique;

        public UniqueBoneShield(string name)
            : base(bonusToHealth, bonusToDefense, bonusToAttack, bonusToIntelligence, name, itemClass, boneShieldType)
        {
            this.itemName = name;
        }

    }
}
