using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.PotionTypes;
using Еscape_from_the_labyrinth_of_death.Interfaces;

namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.GenericItems
{
    abstract class GenericPotion : Item, IPotion
    {
        private const ItemClass itemClass = ItemClass.Potion;
        private bool isUsed;
        private PotionType potionType;
        public PotionType PotionType
        {
            get { return this.potionType; }
        }
        public bool IsUsed
        {
            get
            {
                return this.isUsed;
            }
            protected set
            {
                this.isUsed = value;
            }
        }

        public void UsePotion()
        {
            this.IsUsed = true;
        }

        public GenericPotion(byte healthBonus,
            byte attackBonus,
            byte defenseBonus,
            byte intelligenceBonus,
            string itemName,
            PotionType potionType)

            : base(healthBonus, attackBonus, defenseBonus, intelligenceBonus, itemClass, itemName)
        {
            this.potionType = potionType;
        }
    }
}
