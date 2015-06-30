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
        byte BonusToHealth { get; }
        byte BonusToDefense { get; }
        byte BonusToAttack { get; }
        byte BonusToIntelligence { get; }
        ItemClass ItemClass { get; }
        string ItemName { get; }
    }
}
