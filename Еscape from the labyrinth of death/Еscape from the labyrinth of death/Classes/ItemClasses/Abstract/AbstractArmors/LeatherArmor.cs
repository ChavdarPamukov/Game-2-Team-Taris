namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractArmors
{
    using Еscape_from_the_labyrinth_of_death.Interfaces;
    using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.GenericItems;
    enum LeatherArmorType
    {
        Normal,
        Exceptional,
        Unique,
    }
    abstract class LeatherArmor : GenericArmor
    {
        private byte bonusToHealth;
        private byte bonusToDefense;
        private byte bonusToAttack;
        private byte bonusToIntelligence;
        private string itemName;
        private const ArmorType armorType = ArmorType.LeatherArmor;
        private ItemClass itemClass;
        private LeatherArmorType leatherArmorType;

        public LeatherArmorType LeatherArmorType
        {
            get { return this.leatherArmorType; }
        }

        public LeatherArmor(byte healthBonus,
            byte defenseBonus,
            byte attackBonus,
            byte intelligenceBonus,
            string itemName,
            ItemClass itemClass,
            LeatherArmorType leatherArmorType)
            : base(healthBonus, attackBonus, defenseBonus, intelligenceBonus, itemName, armorType)
        {
        }
    }
}