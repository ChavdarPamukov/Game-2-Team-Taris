using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Еscape_from_the_labyrinth_of_death.Interfaces;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.WeaponTypes;
using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Concrete;

namespace Еscape_from_the_labyrinth_of_death.Factories.ItemFactories.WeaponFactories
{
    public class MaceFactory
    {
        public static readonly MaceFactory MACE_FACTORY = new MaceFactory();
        private readonly MaceType[] _maceTypes;

        private MaceFactory()
        {
            this._maceTypes = new MaceType[]
            {
                MaceType.Flail,
                MaceType.MorningStar,
                MaceType.SpikedClub,
                MaceType.WarHammer,
            };
        }

        public IItem CreateRandom(Random randomGenerator)
        {
            int index = randomGenerator.Next(0, 4);
            MaceType type = this._maceTypes[index];
            switch (type)
            {
                case MaceType.Flail:
                    return this.CreateFlail();
                case MaceType.MorningStar:
                    return this.CreateMorningStar();
                case MaceType.SpikedClub:
                    return this.CreateSpikedClub();
                case MaceType.WarHammer:
                    return this.CreateWarHammer();
                default:
                    throw new ArgumentOutOfRangeException("Invalid mace type: " + type.ToString());
            }
        }

        private IItem CreateFlail()
        {
            return new Flail();
        }

        private IItem CreateMorningStar()
        {
            return new MorningStar();
        }

        private IItem CreateSpikedClub()
        {
            return new SpikedClub();
        }

        private IItem CreateWarHammer()
        {
            return new WarHammer();
        }
    }
}
