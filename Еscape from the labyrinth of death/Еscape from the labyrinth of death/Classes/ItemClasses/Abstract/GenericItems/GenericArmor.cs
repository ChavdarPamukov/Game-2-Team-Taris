namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract
{
    using Еscape_from_the_labyrinth_of_death.Interfaces;
    enum ArmorType
    {
        QuiltedArmor,
        LeatherArmor,
        RingMail,
        BreastPlate
    }
    abstract class GenericWeapon : Item
    {
        private const ItemClass itemClass = ItemClass.Armor;
        private ArmorType armorType;
        public ArmorType ArmorType
        {
            get { return this.armorType; }
        }
        public GenericWeapon(byte healthBonus,
            byte attackBonus,
            byte defenseBonus,
            byte intelligenceBonus,
            string itemName,
            ArmorType armorType)

            : base(healthBonus, attackBonus, defenseBonus, intelligenceBonus, ItemClass.Armor, itemName)
        {
            this.armorType = armorType;
        }
    }
}
