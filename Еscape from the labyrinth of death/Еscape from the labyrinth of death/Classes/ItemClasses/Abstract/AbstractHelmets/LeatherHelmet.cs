namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractHelmets
{
    using Еscape_from_the_labyrinth_of_death.Interfaces;
    using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.GenericItems;
    enum LeatherHelmetType
    {
        Cap,
        WarHat,
        Shako,
    }
    abstract class LeatherHelmet : GenericHelmet
    {
        private byte bonusToHealth;
        private byte bonusToDefense;
        private byte bonusToAttack;
        private byte bonusToIntelligence;
        private string itemName;
        private const HelmetType helmetType = HelmetType.LeatherHelmet;
        private ItemClass itemClass;
        private LeatherHelmetType leatherHelmetType;

        public LeatherHelmetType LeatherHelmetType
        {
            get { return this.leatherHelmetType; }
        }

        public LeatherHelmet(byte healthBonus,
            byte defenseBonus,
            byte attackBonus,
            byte intelligenceBonus,
            string itemName,
            ItemClass itemClass,
            LeatherHelmetType leatherHelmetType)
            : base(healthBonus, attackBonus, defenseBonus, intelligenceBonus, itemName, helmetType)
        {
        }
    }
}