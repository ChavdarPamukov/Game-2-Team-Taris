﻿using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.ShieldTypes;

namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Concrete
{
    using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractShields;
    using Еscape_from_the_labyrinth_of_death.Interfaces;
    class ExceptionalSmallShield : SmallShield
    {
        private const byte bonusToHealth = 0;
        private const byte bonusToDefense = 18;
        private const byte bonusToAttack = 0;
        private const byte bonusToIntelligence = 0;
        private string itemName;
        private const ItemClass itemClass = ItemClass.Shield;
        private const SmallShieldType smallShieldType = SmallShieldType.Exceptional;

        public ExceptionalSmallShield(string name)
            : base(bonusToHealth, bonusToDefense, bonusToAttack, bonusToIntelligence, name, itemClass, smallShieldType)
        {
            this.itemName = name;
        }

    }
}
