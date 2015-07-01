﻿using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.HelmetTypes;

namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Concrete
{
    using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractHelmets;
    using Еscape_from_the_labyrinth_of_death.Interfaces;
    class Shako : LeatherHelmet
    {
        private const byte bonusToHealth = 0;
        private const byte bonusToDefense = 12;
        private const byte bonusToAttack = 0;
        private const byte bonusToIntelligence = 0;
        private string itemName;
        private const ItemClass itemClass = ItemClass.Helmet;
        private const LeatherHelmetType leatherHelmetType = LeatherHelmetType.Shako;

        public Shako(string name)
            : base(bonusToHealth, bonusToDefense, bonusToAttack, bonusToIntelligence, name, itemClass, leatherHelmetType)
        {
            this.itemName = name;
        }

    }
}
