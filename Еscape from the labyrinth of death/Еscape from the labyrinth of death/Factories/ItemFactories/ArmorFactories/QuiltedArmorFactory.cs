using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.ArmorTypes;
using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Concrete;
using Еscape_from_the_labyrinth_of_death.Interfaces;

namespace Еscape_from_the_labyrinth_of_death.Factories.ItemFactories.ArmorFactories
{
    public class QuiltedArmorFactory
    {
        public static readonly QuiltedArmorFactory QUILTED_ARMOR_FACTORY = new QuiltedArmorFactory();
        private readonly QuiltedArmorType[] _armorTypes;

        private QuiltedArmorFactory()
        {
            this._armorTypes = new QuiltedArmorType[]
            {
                QuiltedArmorType.Exceptional,
                QuiltedArmorType.Normal,
                QuiltedArmorType.Unique,
            };
        }

        public IItem CreateRandom(Random randomGenerator)
        {
            int index = randomGenerator.Next(0, 3);
            QuiltedArmorType type = this._armorTypes[index];
            switch (type)
            {
                case QuiltedArmorType.Exceptional:
                    return this.CreateExceptional();
                case QuiltedArmorType.Normal:
                    return this.CreateNormal();
                case QuiltedArmorType.Unique:
                    return this.CreateUnique();
                default:
                    throw new ArgumentOutOfRangeException("Invalid quilted armor type: " + type.ToString());
            }
        }

        private IItem CreateExceptional()
        {
            return new ExceptionalQuiltedArmor();
        }

        private IItem CreateNormal()
        {
            return new NormalQuiltedArmor();
        }

        private IItem CreateUnique()
        {
            return new UniqueQuiltedArmor();
        }
    }
}
