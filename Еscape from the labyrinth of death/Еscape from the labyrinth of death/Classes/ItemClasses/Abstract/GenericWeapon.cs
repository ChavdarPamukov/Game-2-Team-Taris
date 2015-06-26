namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract
{
    using Еscape_from_the_labyrinth_of_death.Interfaces;
    enum WeaponType
    {
        Axe,
        Sword,
        Mace,
        Flail
    }
    abstract class GenericWeapon : Item
    {
        private const ItemClass itemClass = ItemClass.Weapon;
        private WeaponType weaponType;
        public WeaponType WeaponType
        {
            get { return this.weaponType; }
        }
        public GenericWeapon(byte healthBonus,
            byte attackBonus,
            byte defenseBonus,
            byte intelligenceBonus,
            string itemName,
            WeaponType weaponType)

            : base(healthBonus,attackBonus,defenseBonus,intelligenceBonus,itemClass,itemName)
        {
            this.weaponType = weaponType;
        }
    }
}
