namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractArmors
{
    using Еscape_from_the_labyrinth_of_death.Interfaces;
    using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.GenericItems;
    enum RingMailType
    {
        Normal,
        Exceptional,
        Unique,
    }
    abstract class RingMail : GenericArmor
    {
        private byte bonusToHealth;
        private byte bonusToDefense;
        private byte bonusToAttack;
        private byte bonusToIntelligence;
        private string itemName;
        private const ArmorType armorType = ArmorType.RingMail;
        private ItemClass itemClass;
        private RingMailType ringMailType;

        public RingMailType RingMailType
        {
            get { return this.ringMailType; }
        }

        public RingMail(byte healthBonus,
            byte defenseBonus,
            byte attackBonus,
            byte intelligenceBonus,
            string itemName,
            ItemClass itemClass,
            RingMailType ringMailType)
            : base(healthBonus, attackBonus, defenseBonus, intelligenceBonus, itemName, armorType)
        {
        }
    }
}