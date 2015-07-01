using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.PotionTypes;
using Еscape_from_the_labyrinth_of_death.Interfaces;
using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.GenericItems;

namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractPotions
{
    abstract class IntelligencePotion : GenericPotion
    {
        private byte bonusToHealth;
        private byte bonusToDefense;
        private byte bonusToAttack;
        private byte bonusToIntelligence;
        private string itemName;
        private const PotionType potionType = PotionType.IntelligencePotion;
        private ItemClass itemClass;
        private IntelligencePotionType intelligencePotionType;

        public IntelligencePotionType IntelligencePotionType
        {
            get { return this.intelligencePotionType; }
        }

        public IntelligencePotion(byte healthBonus,
            byte defenseBonus,
            byte attackBonus,
            byte intelligenceBonus,
            string itemName,
            ItemClass itemClass,
            IntelligencePotionType intelligencePotionType)
            : base(healthBonus, attackBonus, defenseBonus, intelligenceBonus, itemName, potionType)
        {
            this.intelligencePotionType = intelligencePotionType;
        }
    }
}