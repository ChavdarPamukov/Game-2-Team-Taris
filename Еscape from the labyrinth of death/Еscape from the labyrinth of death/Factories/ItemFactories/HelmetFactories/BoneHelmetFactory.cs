using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.HelmetTypes;
using Еscape_from_the_labyrinth_of_death.Interfaces;
using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Concrete;

namespace Еscape_from_the_labyrinth_of_death.Factories.ItemFactories.HelmetFactories
{
    public class BoneHelmetFactory
    {
        public static readonly BoneHelmetFactory BONE_HELMET_FACTORY = new BoneHelmetFactory();
        private readonly BoneHelmetType[] _boneType;

        private BoneHelmetFactory()
        {
            this._boneType = new BoneHelmetType[]
            {
                BoneHelmetType.BoneHelm,
                BoneHelmetType.BoneVisage,
                BoneHelmetType.GrimHelm,
            };
        }

        public IItem CreateRandom(Random randomGenerator)
        {
            int index = randomGenerator.Next(0, 3);
            BoneHelmetType type = this._boneType[index];
            switch (type)
            {
                case BoneHelmetType.BoneHelm:
                    return this.CreateBoneHelm();
                case BoneHelmetType.BoneVisage:
                    return this.CreateBoneVisage();
                case BoneHelmetType.GrimHelm:
                    return this.CreateGrimHelm();
                default:
                    throw new ArgumentOutOfRangeException("Invalid bone helmet type: " + type.ToString());
            }
        }

        private IItem CreateBoneHelm()
        {
            return new BoneHelm();
        }

        private IItem CreateBoneVisage()
        {
            return new BoneVisage();
        }

        private IItem CreateGrimHelm()
        {
            return new GrimHelm();
        }
    }
}
