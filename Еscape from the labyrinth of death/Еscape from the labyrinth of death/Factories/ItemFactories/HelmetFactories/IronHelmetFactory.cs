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
    public class IronHelmetFactory
    {
        public static readonly IronHelmetFactory IRON_HELMET_FACTORY = new IronHelmetFactory();
        private readonly IronHelmetType[] _ironType;

        private IronHelmetFactory()
        {
            this._ironType = new IronHelmetType[]
            {
                IronHelmetType.Basinet,
                IronHelmetType.FullHelm,
                IronHelmetType.GiantConch,
            };
        }

        public IItem CreateRandom(Random randomGenerator)
        {
            int index = randomGenerator.Next(0, 3);
            IronHelmetType type = this._ironType[index];
            switch (type)
            {
                case IronHelmetType.Basinet:
                    return this.CreateBasinet();
                case IronHelmetType.FullHelm:
                    return this.CreateFullHelm();
                case IronHelmetType.GiantConch:
                    return this.CreateGiantConch();
                default:
                    throw new ArgumentOutOfRangeException("Invalid iron helmet type: " + type.ToString());
            }
        }

        private IItem CreateBasinet()
        {
            return new Basinet();
        }

        private IItem CreateFullHelm()
        {
            return new FullHelm();
        }

        private IItem CreateGiantConch()
        {
            return new GiantConch();
        }
    }
}
