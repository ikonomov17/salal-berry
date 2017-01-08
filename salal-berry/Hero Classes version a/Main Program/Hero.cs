using System;

namespace Main_Program
{
    public class Hero : Creature
    {
        private Gender gender;
        private Size size;
        private int age;

        public Hero()
        {

        }

        public Hero(Gender gender, Size size, int age, int health, int damage, int armor, int strength, int agility, int speed) 
            : base(health, damage, armor, strength, agility, speed)
        {
            this.gender = gender;
            this.size = size;
            this.age = age;
        }

        public Gender Gender
        {           
            get { return this.gender; }
            set { this.gender = value; }
        }
        public Size Size
        {
            get { return this.size; }
            set { this.size = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

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

    }
}
