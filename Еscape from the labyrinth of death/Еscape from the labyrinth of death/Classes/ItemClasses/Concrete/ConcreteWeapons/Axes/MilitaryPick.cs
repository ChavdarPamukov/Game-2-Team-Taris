using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.WeaponTypes;
using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractWeapons;
using Еscape_from_the_labyrinth_of_death.Interfaces;

namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Concrete
{
    public class MilitaryPick : Axe
    {
        private const string name = "Military Pick";
        private const byte bonusToHealth = 0;
        private const byte bonusToDefense = 0;
        private const byte bonusToAttack = 10;
        private const byte bonusToIntelligence = 0;
        private const ItemClass itemClass = ItemClass.Weapon;
        private const AxeType axeType = AxeType.MilitaryPick;

        public MilitaryPick()
            : base(bonusToHealth, bonusToDefense, bonusToAttack, bonusToIntelligence, name, itemClass, axeType)
        {
        }

    }
}
