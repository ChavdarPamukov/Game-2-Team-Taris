using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.HelmetTypes;
using Еscape_from_the_labyrinth_of_death.Interfaces;

namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.GenericItems
{
    abstract class GenericHelmet: Item
    {
        private const ItemClass itemClass = ItemClass.Helmet;
        private HelmetType helmetType;
        public HelmetType HelmetType
        {
            get { return this.helmetType; }
        }
        public GenericHelmet(byte healthBonus,
            byte attackBonus,
            byte defenseBonus,
            byte intelligenceBonus,
            string itemName,
            HelmetType helmetType)

            : base(healthBonus, attackBonus, defenseBonus, intelligenceBonus, itemClass, itemName)
        {
            this.helmetType = helmetType;
        }
    }
}
