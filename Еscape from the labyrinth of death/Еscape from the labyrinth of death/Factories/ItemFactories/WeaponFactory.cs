using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Еscape_from_the_labyrinth_of_death.Interfaces;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.WeaponTypes;
using Еscape_from_the_labyrinth_of_death.Factories.ItemFactories.WeaponFactories;

namespace Еscape_from_the_labyrinth_of_death.Factories.ItemFactories
{
    public class WeaponFactory
    {
        public static readonly WeaponFactory WEAPON_FACTORY = new WeaponFactory();
        private readonly WeaponType[] _weaponTypes;

        private AxeFactory _axeFactory;
        private MaceFactory _maceFactory;
        private SwordFactory _swordFactory;

        private WeaponFactory()
        {
            this._weaponTypes = new WeaponType[]
            {
                WeaponType.Axe,
                WeaponType.Mace,
                WeaponType.Sword,
            };

            this._axeFactory = AxeFactory.AXE_FACTORY;
            this._maceFactory = MaceFactory.MACE_FACTORY;
            this._swordFactory = SwordFactory.SWORD_FACTORY;
        }

        public IItem CretaeRandom(Random randomGenerator)
        {
            int index = randomGenerator.Next(0, 3);
            WeaponType randomType = this._weaponTypes[index];

            switch (randomType)
            {
                case WeaponType.Axe:
                    return this.CreateRandomAxe(randomGenerator);
                case WeaponType.Mace:
                    return this.CreateRandomMace(randomGenerator);
                case WeaponType.Sword:
                    return this.CreateRandomSword(randomGenerator);
                default:
                    throw new ArgumentOutOfRangeException("Invalid weapon type: " + randomType.ToString());
            }
        }

        private IItem CreateRandomAxe(Random randomGenerator)
        {
            return this._axeFactory.CreateRandom(randomGenerator);
        }

        private IItem CreateRandomMace(Random randomGenerator)
        {
            return this._maceFactory.CreateRandom(randomGenerator);
        }

        private IItem CreateRandomSword(Random randomGenerator)
        {
            return this._swordFactory.CreateRandom(randomGenerator);
        }
    }
}
