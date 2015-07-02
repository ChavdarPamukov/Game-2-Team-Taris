using Еscape_from_the_labyrinth_of_death.Classes.EnumClasses;
using Еscape_from_the_labyrinth_of_death.Interfaces;

namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract
{
    public abstract class Item : IItem
    {
        private byte bonusToHealth;
        private byte bonusToDefense;
        private byte bonusToAttack;
        private byte bonusToIntelligence;
        private string itemName;
        private ItemClass itemClass;

        public byte BonusToHealth
        {
            get { return this.bonusToHealth; }
        }

        public byte BonusToDefense
        {
            get { return this.bonusToDefense; }
        }

        public byte BonusToAttack
        {
            get { return this.bonusToAttack; }
        }

        public byte BonusToIntelligence
        {
            get { return this.bonusToIntelligence; }
        }

        public string ItemName
        {
            get { return this.itemName; }
        }

        public ItemClass ItemClass
        {
            get { return this.itemClass; }
        }

        public override string ToString()
        {
            return string.Format("Defence: +{0}\n" +
                "Attack: +{1}\n" +
                "Intelligence: +{2}\n" +
                "Health: +{3}",
                this.BonusToDefense,
                this.BonusToAttack,
                this.BonusToIntelligence,
                this.BonusToHealth);
        }

        public Item(byte healthBonus, byte attackBonus, byte defenseBonus, byte intelligenceBonus, ItemClass itemClass, string itemName)
        {
            this.bonusToAttack = attackBonus;
            this.bonusToDefense = defenseBonus;
            this.bonusToIntelligence = intelligenceBonus;
            this.bonusToHealth = healthBonus;
            this.itemClass = itemClass;
            this.itemName = itemName;
        }
    }
}
