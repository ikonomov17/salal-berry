namespace Main_Program
{
    public interface IWeapon
    {
        int Damage { get; }
        Quality Quality { get; }
        Size Size { get; }
        int Speed { get; }
        WeaponType Type { get; }
    }
}