using System;

namespace Main_Program
{
	public class Monster : Enemy
	{
		private MonsterType type;

		public Monster(DifficultyLevel difficulty)
            : base(difficulty)
		{
            Random setter = new Random();
			this.Type = (MonsterType)setter.Next(0,4);
            this.Health += setter.Next(140, 251);
            this.Armor += setter.Next(2, 6);
            this.Speed -= setter.Next(30, 90);
            this.Damage += setter.Next(1, 10);
            DifficultyBonus(difficulty);
        }

        public MonsterType Type
        {
            get { return this.type; }
            private set { this.type = value; }
        }

        public override void DifficultyBonus(DifficultyLevel difficulty)
        {
            if (difficulty == DifficultyLevel.Easy)
            {
                Random rnd = new Random();
                this.Health -= rnd.Next(80, 120);
                this.Armor -= rnd.Next(2, 5);
                this.Speed -= rnd.Next(90, 140);
                this.Damage -= rnd.Next(4, 7);
            }
            else if (difficulty == DifficultyLevel.Hard)
            {
                Random rnd = new Random();
                this.Health += rnd.Next(80, 120);
                this.Armor += rnd.Next(2, 5);
                this.Damage += rnd.Next(4, 7);
            }
            else
            {

            }
        }



        public override string GetFields()
		{
			return string.Format($"MONSTER:\nHealth={Health},\nDamage={Damage},\nArmor={Armor},\nStrength={Strength},\nAgility={Agility},\nSpeed={Speed},\nDifficulty Level={Difficulty},\nReward={Reward},\nType={Type}\n");
		}
	}
}
