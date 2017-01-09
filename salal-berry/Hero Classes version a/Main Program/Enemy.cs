using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Program
{
    class Enemy : Creature
    {
        // properties
        public Difficulty Rank { get; internal set; }
        public int ScoreReward { get; internal set; }

        // constructors
        public Enemy(Difficulty rank, int scoreReward)
        {
            this.Rank = rank;
            this.ScoreReward = scoreReward;
        }
    }
=======

namespace Main_Program
{
	public abstract class Enemy : Creature
	{
		//Fields:
		private readonly DifficultyLevel difficulty;
		private readonly int reward;

		//Constructor for random generation of all fields
		public Enemy()
		{
			Random rnd = new Random();
			this.difficulty = (DifficultyLevel)rnd.Next(0, 3);
			this.reward = rnd.Next(1, 21);
		}

		//Constructor with all input parmeters
		public Enemy(DifficultyLevel difficulty, int reward, int health, int damage, int armor, int strength, int agility, int speed)
			: base(health, damage, armor, strength, agility, speed)
		{
			this.difficulty = difficulty;
			this.reward = reward;
		}

		//Properties:
		public DifficultyLevel Difficulty
		{
			get { return this.difficulty; }
		}
		public int Reward
		{
			get { return this.reward; }
		}

		//Methods:

		public abstract override string GetFields();

	}
>>>>>>> 3a229a13164ba938523baac54a045913bee1bd48
}
