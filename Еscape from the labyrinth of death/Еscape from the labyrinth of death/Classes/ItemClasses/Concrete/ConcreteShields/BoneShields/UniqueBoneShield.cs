﻿using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.ShieldTypes;
using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractShields;
using Еscape_from_the_labyrinth_of_death.Interfaces;

namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Concrete
{
    public class UniqueBoneShield : BoneShield
    {
        private const string name = "Unique Bone Shield";
        private const byte bonusToHealth = 0;
        private const byte bonusToDefense = 24;
        private const byte bonusToAttack = 0;
        private const byte bonusToIntelligence = 0;
        private const ItemClass itemClass = ItemClass.Shield;
        private const BoneShieldType boneShieldType = BoneShieldType.Unique;

        public UniqueBoneShield()
            : base(bonusToHealth, bonusToDefense, bonusToAttack, bonusToIntelligence, name, itemClass, boneShieldType)
        {
        }

    }
}
