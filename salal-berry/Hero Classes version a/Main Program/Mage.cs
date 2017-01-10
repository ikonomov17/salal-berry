using System;

namespace Main_Program
{
	public class Mage : Hero
	{
		//Fields:
		private readonly MageType type;

		//Constructor for random generation of all fields
		public Mage()
		{
			Random rnd = new Random();
			this.type = (MageType)rnd.Next(0, 3);
		}

		//Constructor with all input parmeters
		public Mage(MageType type, Gender gender, Size size, int age, int health, int damage, int armor, int strength, int agility, int speed)
			: base(gender, size, age, health, damage, armor, strength, agility, speed)
		{
			this.type = type;
		}

		//Properties:
		public MageType Type
		{
			get { return this.type; }
		}

		//Methods:
		public override string GetFields()
		{
			return string.Format($"MAGE:\nHealth={Health},\nDamage={Damage},\nArmor={Armor},\nStrength={Strength},\nAgility={Agility},\nSpeed={Speed},\nGender={Gender},\nSize={Size},\nAge={Age},\nType={Type}\n");
		}
	}
}
