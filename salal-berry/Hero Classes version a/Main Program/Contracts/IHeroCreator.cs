namespace Main_Program
{
    public interface IHeroCreator
    {
        int Age();
        Armor Armor();
        ArmorType ArmorType(int type);
        Hero ClassType();
        Gender Gender();
        Size Size();
        Hero StartUp();
        Weapon Weapon();
        Size WeaponSize(int size);
        WeaponType WeaponType(int type);
    }
}