namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Concrete
{
    using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractHelmets;
    using Еscape_from_the_labyrinth_of_death.Interfaces;
    class GrimHelm : BoneHelmet
    {
        private const byte bonusToHealth = 0;
        private const byte bonusToDefense = 11;
        private const byte bonusToAttack = 0;
        private const byte bonusToIntelligence = 0;
        private string itemName;
        private const ItemClass itemClass = ItemClass.Helmet;
        private const BoneHelmetType boneHelmetType = BoneHelmetType.GrimHelm;

        public GrimHelm(string name)
            : base(bonusToHealth, bonusToDefense, bonusToAttack, bonusToIntelligence, name, itemClass, boneHelmetType)
        {
            this.itemName = name;
        }

    }
}
