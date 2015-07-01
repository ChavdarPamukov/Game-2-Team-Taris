namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Concrete
{
    using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractHelmets;
    using Еscape_from_the_labyrinth_of_death.Interfaces;
    class BoneHelm : BoneHelmet
    {
        private const byte bonusToHealth = 0;
        private const byte bonusToDefense = 7;
        private const byte bonusToAttack = 0;
        private const byte bonusToIntelligence = 0;
        private string itemName;
        private const ItemClass itemClass = ItemClass.Helmet;
        private const BoneHelmetType boneHelmetType = BoneHelmetType.BoneHelm;

        public BoneHelm(string name)
            : base(bonusToHealth, bonusToDefense, bonusToAttack, bonusToIntelligence, name, itemClass, boneHelmetType)
        {
            this.itemName = name;
        }

    }
}
