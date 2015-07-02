using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.HelmetTypes;
using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractHelmets;
using Еscape_from_the_labyrinth_of_death.Interfaces;

namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Concrete
{
    public class GrimHelm : BoneHelmet
    {
        private const string name = "Grim Helm";
        private const byte bonusToHealth = 0;
        private const byte bonusToDefense = 11;
        private const byte bonusToAttack = 0;
        private const byte bonusToIntelligence = 0;
        private const ItemClass itemClass = ItemClass.Helmet;
        private const BoneHelmetType boneHelmetType = BoneHelmetType.GrimHelm;

        public GrimHelm()
            : base(bonusToHealth, bonusToDefense, bonusToAttack, bonusToIntelligence, name, itemClass, boneHelmetType)
        {
        }

    }
}
