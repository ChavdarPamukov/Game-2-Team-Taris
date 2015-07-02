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
    public class SwordFactory
    {
        public static readonly SwordFactory SWORD_FACTORY = new SwordFactory();
        private SwordType[] _swordTypes;

        private SwordFactory()
        {
            this._swordTypes = new SwordType[]
            {
                SwordType.CrystalSword,
                SwordType.LongSword,
                SwordType.Scimitar,
                SwordType.ShortSword,
            };
        }

        public IItem CreateRandom(Random randomGenerator)
        {
            int index = randomGenerator.Next(0, 4);
            SwordType type = this._swordTypes[index];
            switch (type)
            {
                case SwordType.CrystalSword:
                    return this.CreateCrystalSword();
                case SwordType.LongSword:
                    return this.CreateLongSword();
                case SwordType.Scimitar:
                    return this.CreateScimitar();
                case SwordType.ShortSword:
                    return this.CreateShortSword();
                default:
                    throw new ArgumentOutOfRangeException("Invalid sword type: " + type.ToString());
            }
        }

        private IItem CreateCrystalSword()
        {
            return new CrystalSword();
        }

        private IItem CreateLongSword()
        {
            return new LongSword();
        }

        private IItem CreateScimitar()
        {
            return new Scimitar();
        }

        private IItem CreateShortSword()
        {
            return new ShortSword();
        }
    }
}
