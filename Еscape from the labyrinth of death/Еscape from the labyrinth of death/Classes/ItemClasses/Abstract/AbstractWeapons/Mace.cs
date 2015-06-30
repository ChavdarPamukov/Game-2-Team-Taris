namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractWeapons
{
    using Еscape_from_the_labyrinth_of_death.Interfaces;
    enum MaceType
    {
        MorningStar,
        Flail,
        WarHammer,
        SpikedClub
    }
    abstract class Mace : GenericWeapon
    {
        private byte bonusToHealth;
        private byte bonusToDefense;
        private byte bonusToAttack;
        private byte bonusToIntelligence;
        private string itemName;
        private const WeaponType weaponType = WeaponType.Mace;
        private ItemClass itemClass;
        private MaceType maceType;

        public MaceType MaceType
        {
            get { return this.maceType; }
        }

        public Mace(byte healthBonus,
            byte defenseBonus,
            byte attackBonus,
            byte intelligenceBonus,
            string itemName,
            ItemClass itemClass,
            MaceType maceType)
            : base(healthBonus, attackBonus, defenseBonus, intelligenceBonus, itemName, weaponType)
        {
        }
    }
}
