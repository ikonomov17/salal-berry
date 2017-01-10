using System;

namespace Main_Program
{
	public class Bandit : Enemy
	{
		//Fields:
		private readonly BanditType type;

		//Constructor for random generation of all fields
		public Bandit()
		{
			Random rnd = new Random();
			this.type = (BanditType)rnd.Next(0, 2);
		}

		//Constructor with all input parmeters
		public Bandit(BanditType type, DifficultyLevel difficulty, int reward, int age, int health, int damage, int armor, int strength, int agility, int speed)
			: base(difficulty, reward, health, damage, armor, strength, agility, speed)
		{
			this.type = type;
		}

		//Properties:
		public BanditType Type
		{
			get { return this.type; }
		}

		//Methods:
		public override string GetFields()
		{
			return string.Format($"BANDIT:\nHealth={Health},\nDamage={Damage},\nArmor={Armor},\nStrength={Strength},\nAgility={Agility},\nSpeed={Speed},\nDifficulty Level={Difficulty},\nReward={Reward},\nType={Type}\n");
		}
	}
}
