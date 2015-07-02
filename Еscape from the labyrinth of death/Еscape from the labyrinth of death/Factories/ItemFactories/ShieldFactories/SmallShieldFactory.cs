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
    public class SmallShieldFactory
    {
        public static readonly SmallShieldFactory SMALL_SHIELD_FACTORY = new SmallShieldFactory();
        private SmallShieldType[] _shieldTypes;

        private SmallShieldFactory()
        {
            this._shieldTypes = new SmallShieldType[]
            {
                SmallShieldType.Exceptional,
                SmallShieldType.Normal,
                SmallShieldType.Unique,
            };
        }

        public IItem CreateRandom(Random randomGenerator)
        {
            int index = randomGenerator.Next(0, 3);
            SmallShieldType type = this._shieldTypes[index];
            switch (type)
            {
                case SmallShieldType.Exceptional:
                    return this.CreateExceptional();
                case SmallShieldType.Normal:
                    return this.CreateNormal();
                case SmallShieldType.Unique:
                    return this.CreaUnique();
                default:
                    throw new ArgumentOutOfRangeException("Invalid large shiled type: " + type.ToString());
            }
        }

        private IItem CreateExceptional()
        {
            return new ExceptionalSmallShield();
        }

        private IItem CreateNormal()
        {
            return new NormalSmallShield();
        }

        private IItem CreaUnique()
        {
            return new UniqueSmallShield();
        }
    }
}
