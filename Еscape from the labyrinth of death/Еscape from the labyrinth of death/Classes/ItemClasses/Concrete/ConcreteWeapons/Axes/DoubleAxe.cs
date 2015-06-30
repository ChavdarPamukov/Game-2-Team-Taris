﻿namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Concrete
{
    using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractWeapons;
    using Еscape_from_the_labyrinth_of_death.Interfaces;
    class DoubleAxe : Axe
    {
        private const byte bonusToHealth = 0;
        private const byte bonusToDefense = 0;
        private const byte bonusToAttack = 20;
        private const byte bonusToIntelligence = 0;
        private string itemName;
        private const ItemClass itemClass = ItemClass.Weapon;
        private const AxeType axeType = AxeType.DoubleAxe;

        public DoubleAxe(string name)
            : base(bonusToHealth, bonusToDefense, bonusToAttack, bonusToIntelligence, name, itemClass, axeType)
        {
            this.itemName = name;
        }

    }
}
