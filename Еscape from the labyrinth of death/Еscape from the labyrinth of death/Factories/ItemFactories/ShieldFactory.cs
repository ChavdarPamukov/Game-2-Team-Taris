using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Еscape_from_the_labyrinth_of_death.Interfaces;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.ShieldTypes;
using Еscape_from_the_labyrinth_of_death.Factories.ItemFactories.ShieldFactories;

namespace Еscape_from_the_labyrinth_of_death.Factories.ItemFactories
{
    public class ShieldFactory
    {
        public static readonly ShieldFactory SHIELD_FACTORY = new ShieldFactory();
        private readonly ShieldType[] _shieldTypes;

        private readonly BoneShieldFactory _boneShield;
        private readonly LargeShieldFactory _largeShield;
        private readonly SmallShieldFactory _smallShieldFactory;

        private ShieldFactory()
        {
            this._shieldTypes = new ShieldType[]
            {
                ShieldType.BoneShield,
                ShieldType.LargeShield,
                ShieldType.SmallShield,
            };

            this._boneShield = BoneShieldFactory.BONE_SHIELD_FACTORY;
            this._largeShield = LargeShieldFactory.LARGE_SHIELD_FACTORY;
            this._smallShieldFactory = SmallShieldFactory.SMALL_SHIELD_FACTORY;
        }

        public IItem CreateRandom(Random randomGenerator)
        {
            int index = randomGenerator.Next(0, 3);
            ShieldType type = this._shieldTypes[index];
            switch (type)
            {
                case ShieldType.BoneShield:
                    return this.CreateBoneShield(randomGenerator);
                case ShieldType.LargeShield:
                    return this.CreateLargeShield(randomGenerator);
                case ShieldType.SmallShield:
                    return this.CreateSmallShield(randomGenerator);
                default:
                    throw new ArgumentOutOfRangeException("Invalid shield type: " + type.ToString());
            }
        }

        private IItem CreateBoneShield(Random randomGenerator)
        {
            return this._boneShield.CreateRandom(randomGenerator);
        }

        private IItem CreateLargeShield(Random randomGenerator)
        {
            return this._largeShield.CreateRandom(randomGenerator);
        }

        private IItem CreateSmallShield(Random randomGenerator)
        {
            return this._smallShieldFactory.CreateRandom(randomGenerator);
        }
    }
}
