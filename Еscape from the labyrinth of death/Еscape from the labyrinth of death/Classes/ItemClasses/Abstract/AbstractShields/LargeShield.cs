namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractShields
{
    using Еscape_from_the_labyrinth_of_death.Interfaces;
    using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.GenericItems;
    enum LargeShieldType
    {
        Normal,
        Exceptional,
        Unique,
    }
    abstract class LargeShield : GenericShield
    {
        private byte bonusToHealth;
        private byte bonusToDefense;
        private byte bonusToAttack;
        private byte bonusToIntelligence;
        private string itemName;
        private const ShieldType shieldType = ShieldType.LargeShield;
        private ItemClass itemClass;
        private LargeShieldType largeShieldType;

        public LargeShieldType LargeShieldType
        {
            get { return this.largeShieldType; }
        }

        public LargeShield(byte healthBonus,
            byte defenseBonus,
            byte attackBonus,
            byte intelligenceBonus,
            string itemName,
            ItemClass itemClass,
            LargeShieldType largeShieldType)
            : base(healthBonus, attackBonus, defenseBonus, intelligenceBonus, itemName, shieldType)
        {
        }
    }
}