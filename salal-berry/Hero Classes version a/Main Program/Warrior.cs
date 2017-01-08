using System;

namespace Main_Program
{
	public class Warrior : Hero
	{
		//Fields:
		private readonly WarriorType type;

		//Constructor for random generation of all fields
		public Warrior()
		{
			Random rnd = new Random();
			this.type = (WarriorType)rnd.Next(0, 2);
		}

		//Constructor with all input parmeters
		public Warrior(WarriorType type, Gender gender, Size size, int age, int health, int damage, int armor, int strength, int agility, int speed)
			: base(gender, size, age, health, damage, armor, strength, agility, speed)
		{
			this.type = type;
		}

		//Properties:
		public WarriorType Type
		{
			get { return this.type; }
		}


		//Methods:
		public override string GetFields()
		{
			return string.Format($"WARRIOR:\nHealth={Health},\nDamage={Damage},\nArmor={Armor},\nStrength={Strength},\nAgility={Agility},\nSpeed={Speed},\nGender={Gender},\nSize={Size},\nAge={Age},\nType={Type}\n");
		}
	}
}
