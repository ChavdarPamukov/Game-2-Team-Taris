namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Concrete
{
    using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractHelmets;
    using Еscape_from_the_labyrinth_of_death.Interfaces;
    class Basinet : IronHelmet
    {
        private const byte bonusToHealth = 0;
        private const byte bonusToDefense = 11;
        private const byte bonusToAttack = 0;
        private const byte bonusToIntelligence = 0;
        private string itemName;
        private const ItemClass itemClass = ItemClass.Helmet;
        private const IronHelmetType ironHelmetType = IronHelmetType.Basinet;

        public Basinet(string name)
            : base(bonusToHealth, bonusToDefense, bonusToAttack, bonusToIntelligence, name, itemClass, ironHelmetType)
        {
            this.itemName = name;
        }

    }
}
