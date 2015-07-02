using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.HelmetTypes;
using Еscape_from_the_labyrinth_of_death.Interfaces;
using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.GenericItems;

namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractHelmets
{
    public abstract class LeatherHelmet : GenericHelmet
    {
        private const HelmetType helmetType = HelmetType.LeatherHelmet;
        private LeatherHelmetType leatherHelmetType;

        public LeatherHelmetType LeatherHelmetType
        {
            get { return this.leatherHelmetType; }
        }

        public LeatherHelmet(byte healthBonus,
            byte defenseBonus,
            byte attackBonus,
            byte intelligenceBonus,
            string itemName,
            ItemClass itemClass,
            LeatherHelmetType leatherHelmetType)
            : base(healthBonus, attackBonus, defenseBonus, intelligenceBonus, itemName, helmetType)
        {
            this.leatherHelmetType = leatherHelmetType;
        }
    }
}