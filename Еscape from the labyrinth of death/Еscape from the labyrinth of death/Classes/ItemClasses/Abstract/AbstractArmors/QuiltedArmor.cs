namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractArmors
{
    using Еscape_from_the_labyrinth_of_death.Interfaces;
    using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.GenericItems;
    enum QuiltedArmorType
    {
        Normal,
        Exceptional,
        Unique,
    }
    abstract class QuiltedArmor : GenericArmor
    {
        private byte bonusToHealth;
        private byte bonusToDefense;
        private byte bonusToAttack;
        private byte bonusToIntelligence;
        private string itemName;
        private const ArmorType armorType = ArmorType.QuiltedArmor;
        private ItemClass itemClass;
        private QuiltedArmorType quiltedArmorType;

        public QuiltedArmorType QuiltedArmorType
        {
            get { return this.quiltedArmorType; }
        }

        public QuiltedArmor(byte healthBonus,
            byte defenseBonus,
            byte attackBonus,
            byte intelligenceBonus,
            string itemName,
            ItemClass itemClass,
            QuiltedArmorType quiltedArmorType)
            : base(healthBonus, attackBonus, defenseBonus, intelligenceBonus, itemName, armorType)
        {
        }
    }
}