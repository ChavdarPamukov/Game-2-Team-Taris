using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Еscape_from_the_labyrinth_of_death.Interfaces;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.PotionTypes;
using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Concrete;

namespace Еscape_from_the_labyrinth_of_death.Factories.ItemFactories.PotionFactories
{
    public class HealthPotionFactory
    {
        public static readonly HealthPotionFactory HEALTH_POTION_FACTORY = new HealthPotionFactory();
        private readonly HealthPotionType[] _potionTypes;

        private HealthPotionFactory()
        {
            this._potionTypes = new HealthPotionType[]
            {
                HealthPotionType.Large,
                HealthPotionType.Medium,
                HealthPotionType.Small,
            };
        }

        public IItem CreateRandom(Random randomGenerator)
        {
            int index = randomGenerator.Next(0, 3);
            HealthPotionType type = this._potionTypes[index];
            switch (type)
            {
                case HealthPotionType.Large:
                    return this.CreateLarge();
                case HealthPotionType.Medium:
                    return this.CreateMedium();
                case HealthPotionType.Small:
                    return this.CreateSmall();
                default:
                    throw new ArgumentOutOfRangeException("Invalid health potion type: " + type.ToString());
            }
        }

        private IItem CreateLarge()
        {
            return new LargeHealthPotion();
        }

        private IItem CreateMedium()
        {
            return new MediumHealthPotion();
        }

        private IItem CreateSmall()
        {
            return new SmallHealthPotion();
        }
    }
}
