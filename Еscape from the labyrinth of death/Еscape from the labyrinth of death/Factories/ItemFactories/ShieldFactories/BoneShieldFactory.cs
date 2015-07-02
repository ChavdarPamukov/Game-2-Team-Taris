using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Еscape_from_the_labyrinth_of_death.Interfaces;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.ShieldTypes;
using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Concrete;

namespace Еscape_from_the_labyrinth_of_death.Factories.ItemFactories.ShieldFactories
{
    public class BoneShieldFactory
    {
        public static readonly BoneShieldFactory BONE_SHIELD_FACTORY = new BoneShieldFactory();
        private BoneShieldType[] _boneTypes;

        private BoneShieldFactory()
        {
            this._boneTypes = new BoneShieldType[]
            {
                BoneShieldType.Exceptional,
                BoneShieldType.Normal,
                BoneShieldType.Unique,
            };
        }

        public IItem CreateRandom(Random randomGenerator)
        {
            int index = randomGenerator.Next(0, 3);
            BoneShieldType type = this._boneTypes[index];
            switch (type)
            {
                case BoneShieldType.Exceptional:
                    return this.CreateExceptional();
                case BoneShieldType.Normal:
                    return this.CreateNormal();
                case BoneShieldType.Unique:
                    return this.CreaUnique();
                default:
                    throw new ArgumentOutOfRangeException("Invalid bone shiled type: " + type.ToString());
            }
        }

        private IItem CreateExceptional()
        {
            return new ExceptionalBoneShield();
        }

        private IItem CreateNormal()
        {
            return new NormalBoneShield();
        }

        private IItem CreaUnique()
        {
            return new UniqueBoneShield();
        }
    }
}
