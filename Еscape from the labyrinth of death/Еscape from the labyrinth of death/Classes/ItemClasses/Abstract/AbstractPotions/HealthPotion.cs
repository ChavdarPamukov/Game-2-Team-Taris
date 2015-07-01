using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses.ItemTypes.PotionTypes;
using Еscape_from_the_labyrinth_of_death.Interfaces;
using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.GenericItems;

namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractPotions
{
    abstract class HealthPotion : GenericPotion
    {
        private byte bonusToHealth;
        private byte bonusToDefense;
        private byte bonusToAttack;
        private byte bonusToIntelligence;
        private string itemName;
        private const PotionType potionType = PotionType.HealthPotion;
        private ItemClass itemClass;
        private HealthPotionType healthPotionType;

        public HealthPotionType HealthPotionType
        {
            get { return this.healthPotionType; }
        }

        public HealthPotion(byte healthBonus,
            byte defenseBonus,
            byte attackBonus,
            byte intelligenceBonus,
            string itemName,
            ItemClass itemClass,
            HealthPotionType healthPotionType)
            : base(healthBonus, attackBonus, defenseBonus, intelligenceBonus, itemName, potionType)
        {
            this.healthPotionType = healthPotionType;
        }
    }
}