using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.HelmetTypes;
using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractHelmets;
using Еscape_from_the_labyrinth_of_death.Interfaces;

namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Concrete
{
    public class BoneHelm : BoneHelmet
    {
        private const string name = "Bone Helm";
        private const byte bonusToHealth = 0;
        private const byte bonusToDefense = 7;
        private const byte bonusToAttack = 0;
        private const byte bonusToIntelligence = 0;
        private const ItemClass itemClass = ItemClass.Helmet;
        private const BoneHelmetType boneHelmetType = BoneHelmetType.BoneHelm;

        public BoneHelm()
            : base(bonusToHealth, bonusToDefense, bonusToAttack, bonusToIntelligence, name, itemClass, boneHelmetType)
        {
        }

    }
}
