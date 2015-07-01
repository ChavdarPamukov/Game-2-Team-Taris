using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.WeaponTypes;
using Еscape_from_the_labyrinth_of_death.Interfaces;

namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.GenericItems
{
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

            : base(healthBonus,attackBonus,defenseBonus,intelligenceBonus,ItemClass.Weapon,itemName)
        {
            this.weaponType = weaponType;
        }
    }
}
