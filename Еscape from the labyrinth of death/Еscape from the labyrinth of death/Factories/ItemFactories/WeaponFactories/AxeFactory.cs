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
    public class AxeFactory
    {
        public static readonly AxeFactory AXE_FACTORY = new AxeFactory();
        private readonly AxeType[] _axeTypes;

        private AxeFactory()
        {
            this._axeTypes = new AxeType[]
            {
                AxeType.DoubleAxe,
                AxeType.HandAxe,
                AxeType.MilitaryPick,
                AxeType.WarAxe,
            };
        }

        public IItem CreateRandom(Random randomGenerator)
        {
            int index = randomGenerator.Next(0, 4);
            AxeType type = this._axeTypes[index];
            switch (type)
            {
                case AxeType.DoubleAxe:
                    return this.CreateDoubleAxe();
                case AxeType.HandAxe:
                    return this.CreateHandAxe();
                case AxeType.MilitaryPick:
                    return this.CreateMilitaryPick();
                case AxeType.WarAxe:
                    return this.CreateWarAxe();
                default:
                    throw new ArgumentOutOfRangeException("Invalid axe type: " + type);
            }
        }

        private IItem CreateDoubleAxe()
        {
            return new DoubleAxe();
        }

        private IItem CreateHandAxe()
        {
            return new HandAxe();
        }

        private IItem CreateMilitaryPick()
        {
            return new MilitaryPick();
        }

        private IItem CreateWarAxe()
        {
            return new WarAxe();
        }
    }
}
