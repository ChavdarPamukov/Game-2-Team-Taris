using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.WeaponTypes;
using Еscape_from_the_labyrinth_of_death.Interfaces;
using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.GenericItems;

namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractWeapons
{
    public abstract class Mace : GenericWeapon
    {
        private const WeaponType weaponType = WeaponType.Mace;
        private MaceType maceType;

        public MaceType MaceType
        {
            get { return this.maceType; }
        }

        public Mace(byte healthBonus,
            byte defenseBonus,
            byte attackBonus,
            byte intelligenceBonus,
            string itemName,
            ItemClass itemClass,
            MaceType maceType)
            : base(healthBonus, attackBonus, defenseBonus, intelligenceBonus, itemName, weaponType)
        {
            this.maceType = maceType;
        }
    }
}
