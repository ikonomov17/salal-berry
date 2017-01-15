using System;

namespace Main_Program
{
	public abstract class Enemy : Creature
	{
		private DifficultyLevel difficulty;
		private int reward;

		public Enemy(DifficultyLevel difficulty)
		{
			this.Difficulty = difficulty;
		}

		public DifficultyLevel Difficulty
		{
			get { return this.difficulty; }
            private set { this.difficulty = value; }
		}

		public int Reward
		{
			get { return this.reward; }
            private set { this.reward = value; }
        }

        public virtual void DifficultyBonus(DifficultyLevel difficulty)
        {

        }

        public abstract override string GetFields();

	}
}
