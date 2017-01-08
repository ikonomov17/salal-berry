using System;

namespace Main_Program
{
	public abstract class Creature
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

		//Costructor with all input parameters
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
            get { return this.health; }
			protected set { this.health = value; }
        }

        public int Damage
        {
			get { return this.damage; }
			protected set { this.damage = value; }
		}


		public int Armor
        {
			get { return this.armor; }
			protected set { this.armor = value; }
		}


		public int Strength
        {
            get { return this.health; }
			protected set { this.health = value; }
		}


		public int Agility
        {
			get { return this.agility; }
			protected set { this.agility = value; }
		}


		public int Speed
        {
			get { return this.speed; }
			protected set { this.speed = value; }
		}

		//Methods:
		//abstract method to return all fields of an object
		public abstract string GetFields();

		public override string ToString()
		{
			return this.GetFields();
		}

    }
}
