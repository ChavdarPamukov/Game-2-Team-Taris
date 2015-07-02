using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.WeaponTypes;
using Еscape_from_the_labyrinth_of_death.Interfaces;
using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.GenericItems;

namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractWeapons
{
    public abstract class Axe : GenericWeapon
    {
        private const WeaponType weaponType = WeaponType.Axe;
        private AxeType axeType;

        public AxeType AxeType
        {
            get { return this.axeType; }
        }

        public Axe(byte healthBonus,
            byte defenseBonus,
            byte attackBonus,
            byte intelligenceBonus,
            string itemName,
            ItemClass itemClass,
            AxeType axeType)
            : base(healthBonus, attackBonus, defenseBonus, intelligenceBonus, itemName, weaponType)
        {
            this.axeType = axeType;
        }
    }
}
