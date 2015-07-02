using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.HelmetTypes;
using Еscape_from_the_labyrinth_of_death.Interfaces;
using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.GenericItems;

namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractHelmets
{
    public abstract class IronHelmet : GenericHelmet
    {
        private const HelmetType helmetType = HelmetType.IronHelmet;
        private IronHelmetType ironHelmetType;

        public IronHelmetType IronHelmetType
        {
            get { return this.ironHelmetType; }
        }

        public IronHelmet(byte healthBonus,
            byte defenseBonus,
            byte attackBonus,
            byte intelligenceBonus,
            string itemName,
            ItemClass itemClass,
            IronHelmetType ironHelmetType)
            : base(healthBonus, attackBonus, defenseBonus, intelligenceBonus, itemName, helmetType)
        {
            this.ironHelmetType = ironHelmetType;
        }
    }
}