namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractWeapons
{
    using Еscape_from_the_labyrinth_of_death.Interfaces;
    using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.GenericItems;
    enum SwordType
    {
        ShortSword,
        Scimitar,
        CrystalSword,
        LongSword
    }
    abstract class Sword : GenericWeapon
    {
        private byte bonusToHealth;
        private byte bonusToDefense;
        private byte bonusToAttack;
        private byte bonusToIntelligence;
        private string itemName;
        private const WeaponType weaponType = WeaponType.Sword;
        private ItemClass itemClass;
        private SwordType swordType;

        public SwordType SwordType
        {
            get { return this.swordType; }
        }

        public Sword(byte healthBonus,
            byte defenseBonus,
            byte attackBonus,
            byte intelligenceBonus,
            string itemName,
            ItemClass itemClass,
            SwordType swordType)
            : base(healthBonus, attackBonus, defenseBonus, intelligenceBonus, itemName, weaponType)
        {
        }
    }
}
