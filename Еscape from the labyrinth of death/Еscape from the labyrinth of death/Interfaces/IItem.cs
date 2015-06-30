namespace Еscape_from_the_labyrinth_of_death.Interfaces
{
    enum ItemClass
    {
        Weapon,
        Armor,
        Shield,
        Helmet,
        Potion
    }
    interface IItem
    {
        int BonusToHealth { get; }
        int BonusToDefense { get; }
        int BonusToAttack { get; }
        int BonusToIntelligence { get; }
        ItemClass ItemClass { get; }
        string ItemName { get; }
    }
}
