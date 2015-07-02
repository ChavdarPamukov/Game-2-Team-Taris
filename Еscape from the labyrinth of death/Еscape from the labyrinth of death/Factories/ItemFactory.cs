using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Еscape_from_the_labyrinth_of_death.Interfaces;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Factories.ItemFactories;

namespace Еscape_from_the_labyrinth_of_death.Factories
{
    public class ItemFactory : IItemFactory
    {
        public static readonly IItemFactory ITEM_FACTORY = new ItemFactory();
        
        private readonly Random _randomGenerator;

        private readonly WeaponFactory _weaponFactory;
        private readonly ArmorFactory _armorFactory;
        private readonly ShieldFactory _shieldFactory;
        private readonly HelmetFactory _helmetFactory;
        private readonly PotionFactory _potionFactory;

        private ItemFactory()
        {
            this._randomGenerator = new Random();

            this._weaponFactory = WeaponFactory.WEAPON_FACTORY;
            this._armorFactory = ArmorFactory.ARMOR_FACTORY;
            this._shieldFactory = ShieldFactory.SHIELD_FACTORY;
            this._helmetFactory = HelmetFactory.HELMET_FACTORY;
            this._potionFactory = PotionFactory.POTION_FACTORY;
        }

        public IItem CreateRandom(ItemClass itemClass)
        {
            switch (itemClass)
            {
                case ItemClass.Weapon:
                    return this.CreateRandomWeapon(this._randomGenerator);
                case ItemClass.Armor:
                    return this.CreateRandomArmor(this._randomGenerator);
                case ItemClass.Shield:
                    return this.CreateRandomShield(this._randomGenerator);
                case ItemClass.Helmet:
                    return this.CreateRandomHelmet(this._randomGenerator);
                case ItemClass.Potion:
                    return this.CreateRandomPotion(this._randomGenerator);
                default:
                    throw new ArgumentOutOfRangeException("Invalid Item class: " + itemClass.ToString());
            }

            throw new NotImplementedException();
        }

        private IItem CreateRandomWeapon(Random randomGenerator)
        {
            return this._weaponFactory.CretaeRandom(randomGenerator);
        }

        private IItem CreateRandomArmor(Random randomGenerator)
        {
            return this._armorFactory.CreateRandom(randomGenerator);
        }

        private IItem CreateRandomShield(Random randomGenerator)
        {
            return this._shieldFactory.CreateRandom(randomGenerator);
        }

        private IItem CreateRandomHelmet(Random randomGenerator)
        {
            return this._helmetFactory.CreateRandom(randomGenerator);
        }

        private IItem CreateRandomPotion(Random randomGenerator)
        {
            return this._potionFactory.CreateRandom(randomGenerator);
        } 
    }
}
