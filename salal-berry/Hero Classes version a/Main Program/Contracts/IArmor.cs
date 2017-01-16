namespace Main_Program
{
    public interface IArmor
    {
        int ArmorAmount { get; }
        ArmorType ArmorType { get; set; }
        int Health { get; }
        Quality Quality { get; }
        int Speed { get; }
    }
}