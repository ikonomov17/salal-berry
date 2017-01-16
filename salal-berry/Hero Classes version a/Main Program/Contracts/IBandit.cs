namespace Main_Program
{
    public interface IBandit
    {
        BanditType Type { get; }
        Weapon WpType { get; }

        void DifficultyBonus(DifficultyLevel difficulty);
        string GetFields();
    }
}