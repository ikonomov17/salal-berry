using System;

namespace Main_Program
{
    public class Armor : IArmor
    {
        private ArmorType armorType;
        private Quality quality;
        private int health;
        private int speed;
        private int armorAmount;
  
        public Armor(ArmorType armorType)
        {
            Random setter = new Random();
            this.ArmorType = armorType;
            this.Quality = (Quality)setter.Next(0, 5);
            statGenerator();
        }

        public ArmorType ArmorType
        {
            get { return this.armorType; }
            set { this.armorType = value; }
        }

        public Quality Quality
        {
            get { return this.quality; }
            private set { this.quality = value; }
        }

        public int Health
        {
            get { return this.health; }
            private set { this.health = value; }
        }

        public int Speed
        {
            get { return this.speed; }
            private set { this.speed = value; }
        }

        public int ArmorAmount
        {
            get { return this.armorAmount; }
            private set { this.armorAmount = value; }
        }

        private void statGenerator()
        {
            Random setter = new Random();
            this.Health = setter.Next(30, 71);
            this.Speed = setter.Next(-20, 20);
            this.ArmorAmount = setter.Next(-2, 6);

            if (this.ArmorType == ArmorType.leather)
            {
                this.Health += setter.Next(0, 30);
                this.Speed += setter.Next(20, 50);
                this.ArmorAmount += setter.Next(0, 3);
            }
            else if (this.ArmorType == ArmorType.mail)
            {
                this.Health += setter.Next(-10, 40);
                this.Speed += setter.Next(-20, 10);
                this.ArmorAmount += setter.Next(3, 7);
            }
            else if (this.ArmorType == ArmorType.plate)
            {
                this.Health += setter.Next(10, 80);
                this.Speed += setter.Next(-50, 0);
                this.ArmorAmount += setter.Next(5, 10);
            }


            if (this.Quality == Quality.Broken)
            {
                this.Health += setter.Next(-20, -10);
                this.Speed += setter.Next(-10, 0);
                this.ArmorAmount += setter.Next(-3, 0);
            }
            else if (this.Quality == Quality.Damaged)
            {
                this.Health += setter.Next(-10, 0);
                this.Speed += setter.Next(0, 0);
                this.ArmorAmount += setter.Next(-1, 0);
            }
            else if (this.Quality == Quality.Average)
            {
                this.Health += setter.Next(0, 10);
                this.Speed += setter.Next(0, 10);
                this.ArmorAmount += setter.Next(0, 2);
            }
            else if (this.Quality == Quality.Crafted)
            {
                this.Health += setter.Next(10, 20);
                this.Speed += setter.Next(0, 25);
                this.ArmorAmount += setter.Next(1, 4);
            }
            else if (this.Quality == Quality.Artifact)
            {
                this.Health += setter.Next(10, 50);
                this.Speed += setter.Next(10, 30);
                this.ArmorAmount += setter.Next(2, 6);
            }
        }


    }
}
