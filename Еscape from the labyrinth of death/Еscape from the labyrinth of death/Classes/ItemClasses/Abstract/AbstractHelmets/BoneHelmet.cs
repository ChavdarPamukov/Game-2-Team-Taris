using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.HelmetTypes;
using Еscape_from_the_labyrinth_of_death.Interfaces;
using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.GenericItems;

namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractHelmets
{
    public abstract class BoneHelmet : GenericHelmet
    {
        private const HelmetType helmetType = HelmetType.BoneHelmet;
        private BoneHelmetType boneHelmetType;

        public BoneHelmetType BoneHelmetType
        {
            get { return this.boneHelmetType; }
        }

        public BoneHelmet(byte healthBonus,
            byte defenseBonus,
            byte attackBonus,
            byte intelligenceBonus,
            string itemName,
            ItemClass itemClass,
            BoneHelmetType boneHelmetType)
            : base(healthBonus, attackBonus, defenseBonus, intelligenceBonus, itemName, helmetType)
        {
            this.boneHelmetType = boneHelmetType;
        }
    }
}