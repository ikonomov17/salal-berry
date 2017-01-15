using System;

namespace Main_Program
{
	public class Mage : Hero
	{
        private Weapon weaponType;

        public Mage()
		{
		}

		public Mage(Weapon weaponType, Gender gender, Size size, int age)
		{
            this.Health += -10;
            this.Armor += -1;
            this.Speed += 50;
            this.Damage += -1;
            this.Strength += -4;
            InitialInformation();
        }

		public override string GetFields()
		{
			return string.Format($"MAGE:\nHealth={Health},\nDamage={Damage},\nArmor={Armor},\nStrength={Strength},\nAgility={Agility},\nSpeed={Speed},\nGender={Gender},\nSize={Size},\nAge={Age},\n");
		}
	}
}
