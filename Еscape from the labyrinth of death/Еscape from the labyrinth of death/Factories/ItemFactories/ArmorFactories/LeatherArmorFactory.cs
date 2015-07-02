using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Еscape_from_the_labyrinth_of_death.Interfaces;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.ArmorTypes;
using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Concrete;

namespace Еscape_from_the_labyrinth_of_death.Factories.ItemFactories.ArmorFactories
{
    public class LeatherArmorFactory
    {
        public static readonly LeatherArmorFactory LEATHER_ARMOR_FACTORY = new LeatherArmorFactory();
        private LeatherArmorType[] _armorTypes;

        private LeatherArmorFactory()
        {
            this._armorTypes = new LeatherArmorType[]
            {
                LeatherArmorType.Exceptional,
                LeatherArmorType.Normal,
                LeatherArmorType.Unique,
            };
        }

        public IItem CreateRandom(Random randomGenerator)
        {
            int index = randomGenerator.Next(0, 3);
            LeatherArmorType type = this._armorTypes[index];
            switch (type)
            {
                case LeatherArmorType.Exceptional:
                    return this.CreateExceptional();
                case LeatherArmorType.Normal:
                    return this.CreateNormal();
                case LeatherArmorType.Unique:
                    return this.CreateUnique();
                default:
                    throw new ArgumentOutOfRangeException("Leather armor type is invalid: " + type.ToString());
            }
        }

        private IItem CreateExceptional()
        {
            return new ExceptionalLeatherArmor();
        }

        private IItem CreateNormal()
        {
            return new NormalLeatherArmor();
        }

        private IItem CreateUnique()
        {
            return new UniqueLeatherArmor();
        }
    }
}
