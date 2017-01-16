using System;

namespace Main_Program
{
	public abstract class Creature : ICreature
    {
        private int health;
        private int damage;
        private int armor;
        private int strength;
        private int agility;
        private int speed;
        private int dodge;

        public Creature()
        {
			Random rnd = new Random();
            this.Health = rnd.Next(130, 171);
			this.Damage = rnd.Next(3, 9);
			this.Armor = rnd.Next(-2, 3);
			this.Strength = rnd.Next(5, 11);
			this.Agility = rnd.Next(5, 11);
			this.Speed = rnd.Next(85, 116);
        }

        public int Health
        {
            get { return this.health; }
			set { this.health = value; }
        }

        public int Damage
        {
			get { return this.damage; }
			set { this.damage = value; }
		}

		public int Armor
        {
			get { return this.armor; }
			protected set { this.armor = value; }
		}

		public int Strength
        {
            get { return this.strength; }
			protected set { this.strength = value; }
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

		//abstract method to return all fields of an object
		public abstract string GetFields();

		public override string ToString()
		{
			return this.GetFields();
		}

    }
}
