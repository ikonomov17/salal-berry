using System;

namespace Main_Program
{
	public class Monster : Enemy
	{
		//Fields:
		private readonly MonsterType type;

		//Constructor for random generation of all fields
		public Monster()
		{
			Random rnd = new Random();
			this.type = (MonsterType)rnd.Next(0, 3);
		}

		//Constructor with all input parmeters
		public Monster(MonsterType type, DifficultyLevel difficulty, int reward, int age, int health, int damage, int armor, int strength, int agility, int speed)
			: base(difficulty, reward, health, damage, armor, strength, agility, speed)
		{
			this.type = type;
		}

		//Properties:
		public MonsterType Type
		{
			get { return this.type; }
		}

		//Methods:
		public override string GetFields()
		{
			return string.Format($"MONSTER:\nHealth={Health},\nDamage={Damage},\nArmor={Armor},\nStrength={Strength},\nAgility={Agility},\nSpeed={Speed},\nDifficulty Level={Difficulty},\nReward={Reward},\nType={Type}\n");
		}
	}
}
