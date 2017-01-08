using System;

namespace Main_Program
{
    public abstract class Hero : Creature
    {
		//Fields:
		private readonly Gender gender;
        private readonly Size size;
		private readonly int age;

		//Constructor for random generation of all fields
		public Hero()
		{
			Random rnd = new Random();
			this.gender = (Gender)rnd.Next(0, 2);
			this.size = (Size)rnd.Next(0, 3);
			this.age = rnd.Next(20, 60);
		}

		//Constructor with all input parmeters
        public Hero(Gender gender, Size size, int age, int health, int damage, int armor, int strength, int agility, int speed) 
            : base(health, damage, armor, strength, agility, speed)
        {
			this.gender = gender;
			this.size = size;
			this.age = age;
        }

		//Properties
		public Gender Gender 
		{
			get { return this.gender; }
		}
		public Size Size
		{
			get { return this.size; }
		}
		public int Age
		{
			get { return this.age; }
		}

		//Methods:
        //this method makes the variables age, gender and size meaningful, by adding different benefits to the functional fields
        public void InitialInformation()
        {          
            if (this.age >= 40)
            {
                this.Damage = this.Damage + 5;
            }
            else
            {
                this.Health = this.Health + 20;
            }

            if (this.Gender == Gender.Male)
            {
                this.Strength = this.Strength + 3;
            }
            else
            {
                this.Agility = this.Agility + 3;
            }

            if (this.Size == Size.Average)
            {
                this.Strength = this.Strength + 1;
                this.Agility = this.Agility + 1;
            }
            else if (this.Size == Size.Large)
            {
                this.Strength = this.Strength + 3;
                this.Agility = this.Agility - 1;
            }
            else if (this.Size == Size.Small)
            {
                this.Strength = this.Strength - 1;
                this.Agility = this.Agility + 3;
            }
        }
        //this method adds the benefits of strength
        public void AdditionalInformation()
        {
            this.Health = this.Health + this.Strength * 3;
            this.Damage = this.Damage + this.Strength;
        }

		public abstract override string GetFields();

    }
}
