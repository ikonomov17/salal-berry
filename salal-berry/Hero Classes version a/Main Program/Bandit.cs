using System;

namespace Main_Program
{
	public class Bandit : Enemy, IBandit
    {
        private BanditType type;
        private Weapon weapon;

        public Bandit(DifficultyLevel difficulty, Weapon weapon)
            : base(difficulty)
		{
            Random setter = new Random();
            this.Type = (BanditType)setter.Next(0, 3);
            this.WpType = weapon;
            this.Health += setter.Next(40, 151);
            this.Armor += setter.Next(1, 3);
            this.Speed += setter.Next(10, 90);
            this.Damage += weapon.Damage;
            DifficultyBonus(difficulty);
        }

        public BanditType Type
        {
            get { return this.type; }
            private set { this.type = value; }
        }

        public Weapon WpType
        {
            get { return this.weapon; }
            private set { this.weapon = value; }
        }

        public override void DifficultyBonus(DifficultyLevel difficulty)
        {
            if (difficulty == DifficultyLevel.Easy)
            {
                Random rnd = new Random();
                this.Health -= rnd.Next(40, 90);
                this.Armor -= rnd.Next(1, 3);
                this.Speed -= rnd.Next(10, 40);
                this.Damage -= rnd.Next(1, 3);
            }
            else if (difficulty == DifficultyLevel.Hard)
            {
                Random rnd = new Random();
                this.Health += rnd.Next(40, 90);
                this.Armor += rnd.Next(1, 3);
                this.Speed += rnd.Next(10, 40);
                this.Damage += rnd.Next(1, 3);
            }
            else
            {

            }
        }

        public override string GetFields()
		{
			return string.Format($"BANDIT:\nHealth={Health},\nDamage={Damage},\nArmor={Armor},\nStrength={Strength},\nAgility={Agility},\nSpeed={Speed},\nDifficulty Level={Difficulty},\nReward={Reward},\nType={Type}\n");
		}
	}
}
