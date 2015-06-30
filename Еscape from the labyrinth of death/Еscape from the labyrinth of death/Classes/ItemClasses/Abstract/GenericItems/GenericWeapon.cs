﻿namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.GenericItems
{
    using Еscape_from_the_labyrinth_of_death.Interfaces;
    enum WeaponType
    {
        Axe,
        Sword,
        Mace,
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

            : base(healthBonus,attackBonus,defenseBonus,intelligenceBonus,ItemClass.Weapon,itemName)
        {
            this.weaponType = weaponType;
        }
    }
}
