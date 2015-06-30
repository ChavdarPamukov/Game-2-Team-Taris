namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractWeapons
{
    using Еscape_from_the_labyrinth_of_death.Interfaces;
    enum AxeType
    {
        HandAxe,
        DoubleAxe,
        WarAxe,
        MilitaryPick
    }
    abstract class Axe : GenericWeapon
    {
        private byte bonusToHealth;
        private byte bonusToDefense;
        private byte bonusToAttack;
        private byte bonusToIntelligence;
        private string itemName;
        private const WeaponType weaponType = WeaponType.Axe;
        private ItemClass itemClass;
        private AxeType axeType;

        public AxeType AxeType
        {
            get { return this.axeType; }
        }

        public Axe(byte healthBonus,
            byte defenseBonus,
            byte attackBonus,
            byte intelligenceBonus,
            string itemName,
            ItemClass itemClass,
            AxeType axeType)
            : base(healthBonus, attackBonus, defenseBonus, intelligenceBonus, itemName, weaponType)
        {
        }
    }
}
