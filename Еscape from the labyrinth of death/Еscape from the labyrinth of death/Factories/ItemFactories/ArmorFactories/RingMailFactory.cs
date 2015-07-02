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
    public class RingMailFactory
    {
        public static readonly RingMailFactory RING_MAIL_FACTORY = new RingMailFactory();
        private readonly RingMailType[] _armorTypes;

        private RingMailFactory()
        {
            this._armorTypes = new RingMailType[]
            {
                RingMailType.Exceptional,
                RingMailType.Normal,
                RingMailType.Unique,
            };
        }

        public IItem CreateRandom(Random randomGenerator)
        {
            int index = randomGenerator.Next(0, 3);
            RingMailType type = this._armorTypes[index];
            switch (type)
            {
                case RingMailType.Exceptional:
                    return this.CreateExceptional();
                case RingMailType.Normal:
                    return this.CreateNormal();
                case RingMailType.Unique:
                    return this.CreateUnique();
                default:
                    throw new ArgumentOutOfRangeException("Invalid ring mail type: " + type.ToString());
            }
        }

        private IItem CreateExceptional()
        {
            return new ExceptionalRingMail();
        }

        private IItem CreateNormal()
        {
            return new NormalRingMail();
        }

        private IItem CreateUnique()
        {
            return new UniqueRingMail();
        }
    }
}
