using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.HelmetTypes;
using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractHelmets;
using Еscape_from_the_labyrinth_of_death.Interfaces;

namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Concrete
{
    public class Shako : LeatherHelmet
    {
        private const string name = "Shako";
        private const byte bonusToHealth = 0;
        private const byte bonusToDefense = 12;
        private const byte bonusToAttack = 0;
        private const byte bonusToIntelligence = 0;
        private const ItemClass itemClass = ItemClass.Helmet;
        private const LeatherHelmetType leatherHelmetType = LeatherHelmetType.Shako;

        public Shako()
            : base(bonusToHealth, bonusToDefense, bonusToAttack, bonusToIntelligence, name, itemClass, leatherHelmetType)
        {
        }

    }
}
