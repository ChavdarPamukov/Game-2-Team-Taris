namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.GenericItems
{
    using Еscape_from_the_labyrinth_of_death.Interfaces;
    enum HelmetType
    {
        LeatherHelmet,
        IronHelmet,
        BoneHelmet
    }
    abstract class GenericHelmet: Item
    {
        private const ItemClass itemClass = ItemClass.Helmet;
        private HelmetType helmetType;
        public HelmetType HelmetType
        {
            get { return this.helmetType; }
        }
        public GenericHelmet(byte healthBonus,
            byte attackBonus,
            byte defenseBonus,
            byte intelligenceBonus,
            string itemName,
            HelmetType helmetType)

            : base(healthBonus, attackBonus, defenseBonus, intelligenceBonus, itemClass, itemName)
        {
            this.helmetType = helmetType;
        }
    }
}
