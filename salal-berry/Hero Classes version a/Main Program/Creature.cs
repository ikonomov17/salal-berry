using System;

namespace Main_Program
{
    public class Creature
    {
		//Fields:
        private int health;
        private int damage;
        private int armor;
        private int strength;
        private int agility;
        private int speed;

		//Constructor for random generation of the fields
        public Creature()
        {
			Random rnd = new Random();
            this.Health = rnd.Next(130, 171);
			this.Damage = rnd.Next(3, 7);
			this.Armor = rnd.Next(0, 2);
			this.Strength = rnd.Next(5, 10);
			this.Agility = rnd.Next(5, 10);
			this.Speed = rnd.Next(85, 115);
        }

		//Costructor with input parameters
		public Creature(int health, int damage, int armor, int strength, int agility, int speed)
		{
			this.Health = health;
			this.Damage = damage;
			this.Armor = armor;
			this.Strength = strength;
			this.Agility = agility;
			this.Speed = speed;
		}

		//Properties:
        public int Health
        {
            get 
			{
				return this.health;
			}

			protected set 
			{
				if (true) // true will be updated with the needed check later
				{
					this.health = value;
				}
				else
				{
					throw new InvalidChoiceException("Value is out of range.");
				}
			}
        }

        public int Damage
        {
            get
			{
				return this.damage;
			}

			protected set
			{
				if (true) // true will be updated with the needed check later
				{
					this.damage = value;
				}
				else
				{
					throw new InvalidChoiceException("Value is out of range.");
				}
			}
        }

        public int Armor
        {
            get
			{
				return this.armor;
			}

			protected set
			{
				if (true) // true will be updated with the needed check later
				{
					this.armor = value;
				}
				else
				{
					throw new InvalidChoiceException("Value is out of range.");
				}
			}
        }

        public int Strength
        {
            get
			{
				return this.strength;
			}

			protected set
			{
				if (true) // true will be updated with the needed check later
				{
					this.strength = value;
				}
				else
				{
					throw new InvalidChoiceException("Value is out of range.");
				}
			}
        }

        public int Agility
        {
            get
			{
				return this.agility;
			}

			protected set
			{
				if (true) // true will be updated with the needed check later
				{
					this.agility = value;
				}
				else
				{
					throw new InvalidChoiceException("Value is out of range.");
				}
			}
        }

        public int Speed
        {
            get
			{
				return this.speed;
			}

			protected set
			{
				if (true) // true will be updated with the needed check later
				{
					this.speed = value;
				}
				else
				{
					throw new InvalidChoiceException("Value is out of range.");
				}
			}
        }
    }
}
