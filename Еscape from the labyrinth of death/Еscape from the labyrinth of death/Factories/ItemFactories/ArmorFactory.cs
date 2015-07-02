using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Еscape_from_the_labyrinth_of_death.Interfaces;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.ArmorTypes;
using Еscape_from_the_labyrinth_of_death.Factories.ItemFactories.ArmorFactories;

namespace Еscape_from_the_labyrinth_of_death.Factories.ItemFactories
{
    public class ArmorFactory
    {
        public static readonly ArmorFactory ARMOR_FACTORY = new ArmorFactory();
        private readonly ArmorType[] _armorTypes;

        private readonly LeatherArmorFactory _leatherFactory;
        private readonly QuiltedArmorFactory _quiltedFactory;
        private readonly RingMailFactory _rindMailFactory;

        private ArmorFactory()
        {
            this._armorTypes = new ArmorType[]
            {
                ArmorType.LeatherArmor,
                ArmorType.QuiltedArmor,
                ArmorType.RingMail,
            };

            this._leatherFactory = LeatherArmorFactory.LEATHER_ARMOR_FACTORY;
            this._quiltedFactory = QuiltedArmorFactory.QUILTED_ARMOR_FACTORY;
            this._rindMailFactory = RingMailFactory.RING_MAIL_FACTORY;
        }
 
        public IItem CreateRandom(Random randomGenerator) 
        {
            int index = randomGenerator.Next(0, 3);
            ArmorType type = this._armorTypes[index];
            switch (type)
            {
                case ArmorType.LeatherArmor:
                    return this.CreateRandomLeatherArmor(randomGenerator);
                case ArmorType.QuiltedArmor:
                    return this.CreateRandomQuiltedArmor(randomGenerator);
                case ArmorType.RingMail:
                    return this.CreateRandomRingMail(randomGenerator);
                default:
                    throw new ArgumentOutOfRangeException("Invalid Armor type: " + type);
            }
        }

        private IItem CreateRandomLeatherArmor(Random randomGenerator)
        {
            return this._leatherFactory.CreateRandom(randomGenerator);
        }

        private IItem CreateRandomQuiltedArmor(Random randomGenerator)
        {
            return this._quiltedFactory.CreateRandom(randomGenerator);
        }

        private IItem CreateRandomRingMail(Random randomGenerator)
        {
            return this._rindMailFactory.CreateRandom(randomGenerator);
        }
    }
}
