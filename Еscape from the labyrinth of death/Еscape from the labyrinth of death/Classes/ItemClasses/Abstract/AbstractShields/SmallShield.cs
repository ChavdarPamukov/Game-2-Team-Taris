namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractShields
{
    using Еscape_from_the_labyrinth_of_death.Interfaces;
    using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.GenericItems;
    enum SmallShieldType
    {
        Normal,
        Exceptional,
        Unique,
    }
    abstract class SmallShield : GenericShield
    {
        private byte bonusToHealth;
        private byte bonusToDefense;
        private byte bonusToAttack;
        private byte bonusToIntelligence;
        private string itemName;
        private const ShieldType shieldType = ShieldType.SmallShield;
        private ItemClass itemClass;
        private SmallShieldType smallShieldType;

        public SmallShieldType SmallShieldType
        {
            get { return this.smallShieldType; }
        }

        public SmallShield(byte healthBonus,
            byte defenseBonus,
            byte attackBonus,
            byte intelligenceBonus,
            string itemName,
            ItemClass itemClass,
            SmallShieldType smallShieldType)
            : base(healthBonus, attackBonus, defenseBonus, intelligenceBonus, itemName, shieldType)
        {
        }
    }
}