namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract
{
    using Еscape_from_the_labyrinth_of_death.Interfaces;
    abstract class Item : IItem
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
