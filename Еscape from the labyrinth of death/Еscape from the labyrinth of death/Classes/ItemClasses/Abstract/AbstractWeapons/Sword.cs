using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.WeaponTypes;
using Еscape_from_the_labyrinth_of_death.Interfaces;
using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.GenericItems;

namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractWeapons
{
    public abstract class Sword : GenericWeapon
    {
        private const WeaponType weaponType = WeaponType.Sword;
        private SwordType swordType;

        public SwordType SwordType
        {
            get { return this.swordType; }
        }

        public Sword(byte healthBonus,
            byte defenseBonus,
            byte attackBonus,
            byte intelligenceBonus,
            string itemName,
            ItemClass itemClass,
            SwordType swordType)
            : base(healthBonus, attackBonus, defenseBonus, intelligenceBonus, itemName, weaponType)
        {
            this.swordType = swordType;
        }
    }
}
