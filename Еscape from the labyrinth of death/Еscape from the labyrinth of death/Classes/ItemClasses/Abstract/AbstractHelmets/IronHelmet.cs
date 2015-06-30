namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractHelmets
{
    using Еscape_from_the_labyrinth_of_death.Interfaces;
    using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.GenericItems;
    enum IronHelmetType
    {
        FullHelm,
        Basinet,
        GiantConch,
    }
    abstract class IronHelmet : GenericHelmet
    {
        private byte bonusToHealth;
        private byte bonusToDefense;
        private byte bonusToAttack;
        private byte bonusToIntelligence;
        private string itemName;
        private const HelmetType helmetType = HelmetType.IronHelmet;
        private ItemClass itemClass;
        private IronHelmetType ironHelmetType;

        public IronHelmetType IronHelmetType
        {
            get { return this.ironHelmetType; }
        }

        public IronHelmet(byte healthBonus,
            byte defenseBonus,
            byte attackBonus,
            byte intelligenceBonus,
            string itemName,
            ItemClass itemClass,
            IronHelmetType ironHelmetType)
            : base(healthBonus, attackBonus, defenseBonus, intelligenceBonus, itemName, helmetType)
        {
        }
    }
}