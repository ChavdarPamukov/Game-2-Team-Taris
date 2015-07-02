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
    public class LargeShieldFactory
    {
        public static readonly LargeShieldFactory LARGE_SHIELD_FACTORY = new LargeShieldFactory();
        private LargeShieldType[] _shiledTypes;

        private LargeShieldFactory()
        {
            this._shiledTypes = new LargeShieldType[]
            {
                LargeShieldType.Exceptional,
                LargeShieldType.Normal,
                LargeShieldType.Unique,
            };
        }

        public IItem CreateRandom(Random randomGenerator)
        {
            int index = randomGenerator.Next(0, 3);
            LargeShieldType type = this._shiledTypes[index];
            switch (type)
            {
                case LargeShieldType.Exceptional:
                    return this.CreateExceptional();
                case LargeShieldType.Normal:
                    return this.CreateNormal();
                case LargeShieldType.Unique:
                    return this.CreaUnique();
                default:
                    throw new ArgumentOutOfRangeException("Invalid large shiled type: " + type.ToString());
            }
        }

        private IItem CreateExceptional()
        {
            return new ExceptionalLargeShield();
        }

        private IItem CreateNormal()
        {
            return new NormalLargeShield();
        }

        private IItem CreaUnique()
        {
            return new UniqueLargeShield();
        }
    }
}
