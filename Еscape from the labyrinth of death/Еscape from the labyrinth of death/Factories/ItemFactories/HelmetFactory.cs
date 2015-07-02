using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Еscape_from_the_labyrinth_of_death.Interfaces;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.HelmetTypes;
using Еscape_from_the_labyrinth_of_death.Factories.ItemFactories.HelmetFactories;

namespace Еscape_from_the_labyrinth_of_death.Factories.ItemFactories
{
    public class HelmetFactory
    {
        public static readonly HelmetFactory HELMET_FACTORY = new HelmetFactory();
        private readonly HelmetType[] _helmetType;

        private readonly BoneHelmetFactory _boneHelmet;
        private readonly IronHelmetFactory _ironHelmet;
        private readonly LeatherHelmetFactory _leatherHelmet;

        private HelmetFactory()
        {
            this._helmetType = new HelmetType[] 
            {
                HelmetType.BoneHelmet,
                HelmetType.IronHelmet,
                HelmetType.LeatherHelmet,
            };

            this._boneHelmet = BoneHelmetFactory.BONE_HELMET_FACTORY;
            this._ironHelmet = IronHelmetFactory.IRON_HELMET_FACTORY;
            this._leatherHelmet = LeatherHelmetFactory.LEATHER_HELMET_FACTORY;
        }

        public IItem CreateRandom(Random randomGenerator)
        {
            int index = randomGenerator.Next(0, 3);
            HelmetType type = this._helmetType[index];
            switch (type)
            {
                case HelmetType.BoneHelmet:
                    return this.CreateBoneHelmet(randomGenerator);
                case HelmetType.IronHelmet:
                    return this.CreateIronHelmet(randomGenerator);
                case HelmetType.LeatherHelmet:
                    return this.CreateLeatherHelmet(randomGenerator);
                default:
                    throw new ArgumentOutOfRangeException("Helmet type invalid: " + type.ToString());
            }
        }

        private IItem CreateBoneHelmet(Random randomGenerator)
        {
            return this._boneHelmet.CreateRandom(randomGenerator);
        }

        private IItem CreateIronHelmet(Random randomGenerator)
        {
            return this._ironHelmet.CreateRandom(randomGenerator);
        }

        private IItem CreateLeatherHelmet(Random randomGenerator)
        {
            return this._leatherHelmet.CreateRandom(randomGenerator);
        }
    }
}
