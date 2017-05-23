namespace Main_Program
{
    public interface IMonster
    {
        MonsterType Type { get; }

        void DifficultyBonus(DifficultyLevel difficulty);
        string GetFields();
    }
}