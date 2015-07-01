﻿using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.ShieldTypes;
using Еscape_from_the_labyrinth_of_death.Interfaces;
using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.GenericItems;

namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractShields
{
    abstract class BoneShield : GenericShield
    {
        private byte bonusToHealth;
        private byte bonusToDefense;
        private byte bonusToAttack;
        private byte bonusToIntelligence;
        private string itemName;
        private const ShieldType shieldType = ShieldType.BoneShield;
        private ItemClass itemClass;
        private BoneShieldType boneShieldType;

        public BoneShieldType BoneShieldType
        {
            get { return this.boneShieldType; }
        }

        public BoneShield(byte healthBonus,
            byte defenseBonus,
            byte attackBonus,
            byte intelligenceBonus,
            string itemName,
            ItemClass itemClass,
            BoneShieldType boneShieldType)
            : base(healthBonus, attackBonus, defenseBonus, intelligenceBonus, itemName, shieldType)
        {
            this.boneShieldType = boneShieldType;
        }
    }
}