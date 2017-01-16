namespace Main_Program
{
    public interface IEnemy
    {
        DifficultyLevel Difficulty { get; }
        int Reward { get; }

        void DifficultyBonus(DifficultyLevel difficulty);
        string GetFields();
    }
}