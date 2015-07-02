using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Еscape_from_the_labyrinth_of_death.Interfaces;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.PotionTypes;
using Еscape_from_the_labyrinth_of_death.Factories.ItemFactories.PotionFactories;

namespace Еscape_from_the_labyrinth_of_death.Factories.ItemFactories
{
    public class PotionFactory
    {
        public static readonly PotionFactory POTION_FACTORY = new PotionFactory();
        private readonly HealthPotionFactory _healthPotion;

        private PotionFactory()
        {
            this._healthPotion = HealthPotionFactory.HEALTH_POTION_FACTORY;
        }

        public IItem CreateRandom(Random randomGenerator)
        {
            return this.CreateHealthPotion(randomGenerator);
        }

        private IItem CreateHealthPotion(Random randomGenerator)
        {
            return this._healthPotion.CreateRandom(randomGenerator);
        }
    }
}
