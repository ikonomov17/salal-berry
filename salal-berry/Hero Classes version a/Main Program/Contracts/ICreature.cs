namespace Main_Program
{
    public interface ICreature
    {
        int Agility { get; }
        int Armor { get; }
        int Damage { get; }
        int Health { get; set; }
        int Speed { get; }
        int Strength { get; }

        string GetFields();
        string ToString();
    }
}