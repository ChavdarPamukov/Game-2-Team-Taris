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
    public class LeatherHelmetFactory
    {
        public static readonly LeatherHelmetFactory LEATHER_HELMET_FACTORY = new LeatherHelmetFactory();
        private readonly LeatherHelmetType[] _leatherType;

        private LeatherHelmetFactory()
        {
            this._leatherType = new LeatherHelmetType[]
            {
                LeatherHelmetType.Cap,
                LeatherHelmetType.Shako,
                LeatherHelmetType.WarHat,
            };
        }

        public IItem CreateRandom(Random randomGenerator)
        {
            int index = randomGenerator.Next(0, 3);
            LeatherHelmetType type = this._leatherType[index];
            switch (type)
            {
                case LeatherHelmetType.Cap:
                    return this.CreateCap();
                case LeatherHelmetType.Shako:
                    return this.CreateShako();
                case LeatherHelmetType.WarHat:
                    return this.CreateWarHat();
                default:
                    throw new ArgumentOutOfRangeException("Invalid iron helmet type: " + type.ToString());
            }
        }

        private IItem CreateCap()
        {
            return new Cap();
        }

        private IItem CreateShako()
        {
            return new Shako();
        }

        private IItem CreateWarHat()
        {
            return new WarHat();
        }
    }
}
