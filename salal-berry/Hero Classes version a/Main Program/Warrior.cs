using System;

namespace Main_Program
{
	public class Warrior : Hero
	{
        private Weapon weaponType;
        private Armor armorType;

		public Warrior()
		{
			
		}

		public Warrior(Weapon weaponType, Armor armorType, Gender gender, Size size, int age)
		{
            this.Health += armorType.Health + 20;
            this.Armor += armorType.ArmorAmount;
            this.Speed += armorType.Speed + weaponType.Speed;
            this.Damage += weaponType.Damage + 3;
            InitialInformation();
        }

		public override string GetFields()
		{
			return string.Format($"WARRIOR:\nHealth={Health},\nDamage={Damage},\nArmor={Armor},\nStrength={Strength},\nAgility={Agility},\nSpeed={Speed},\nGender={Gender},\nSize={Size},\nAge={Age},\n");
		}
	}
}
