namespace Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.AbstractHelmets
{
    using Еscape_from_the_labyrinth_of_death.Interfaces;
    using Еscape_from_the_labyrinth_of_death.Classes.ItemClasses.Abstract.GenericItems;
    enum BoneHelmetType
    {
        BoneHelm,
        GrimHelm,
        BoneVisage,
    }
    abstract class BoneHelmet : GenericHelmet
    {
        private byte bonusToHealth;
        private byte bonusToDefense;
        private byte bonusToAttack;
        private byte bonusToIntelligence;
        private string itemName;
        private const HelmetType helmetType = HelmetType.BoneHelmet;
        private ItemClass itemClass;
        private BoneHelmetType boneHelmetType;

        public BoneHelmetType BoneHelmetType
        {
            get { return this.boneHelmetType; }
        }

        public BoneHelmet(byte healthBonus,
            byte defenseBonus,
            byte attackBonus,
            byte intelligenceBonus,
            string itemName,
            ItemClass itemClass,
            BoneHelmetType boneHelmetType)
            : base(healthBonus, attackBonus, defenseBonus, intelligenceBonus, itemName, helmetType)
        {
        }
    }
}