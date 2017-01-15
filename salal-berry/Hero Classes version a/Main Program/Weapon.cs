using System;
using System.Collections.Generic;

namespace Main_Program
{
    public class Weapon
    {
        private WeaponType type;
        private Size size;
        private Quality quality;
        private int damage;
        private int speed;

        public Weapon(WeaponType type, Size size)
        {
            Random setter = new Random();
            this.Type = type;
            this.Size = size;
            this.Quality = (Quality)setter.Next(0, 5);
            damageGenerator();
        }

        public Weapon()
        {
            Random setter = new Random();
            this.Type = (WeaponType)setter.Next(0, 5);
            this.Size = (Size)setter.Next(0, 3);
            this.Quality = (Quality)setter.Next(0, 5);
            damageGenerator();
        }


        public WeaponType Type
        {
            get { return this.type; }
            private set { this.type = value; }
        }

        public Size Size
        {
            get { return this.size; }
            private set { this.size = value; }
        }

        public Quality Quality
        {
            get { return quality; }
            private set { this.quality = value; }
        }

        public int Damage
        {
            get { return this.damage; }
        }

        public int Speed
        {
            get { return this.speed; }
        }

        //weapon damage/speed are dependant on the type, size and quality

        private int damageGenerator()
        {
            //TYPE
            Random setter = new Random();
            this.damage = setter.Next(10, 15);
            if (this.type == WeaponType.Sword)
            {
                this.damage += 1;
            }
            else if (this.type == WeaponType.Axe)
            {
                this.damage += 3;
            }
            else if (this.type == WeaponType.Hammer)
            {
                this.damage += 7;                                
            }
            else if (this.type == WeaponType.Spear)
            {
                this.damage -= 1;
            }
            else if (this.type == WeaponType.Knife)
            {
                this.damage -= 4;
            }

            //QUALITY
            if (this.quality == Quality.Broken)
            {
                this.damage -= 3;
            }
            else if (this.quality == Quality.Damaged)
            {
                this.damage -= 1;
            }
            else if (this.quality == Quality.Average)
            {
                this.damage += 0;
            }
            else if (this.quality == Quality.Crafted)
            {
                this.damage += 2;
            }
            else if (this.quality == Quality.Artifact)
            {
                this.damage += 4;
            }

            //SIZE
            if (this.size == Size.Large)
            {
                this.damage += 3;
            }
            else if (this.size == Size.Average)
            {
                this.damage += 0;
            }
            else if (this.size == Size.Small)
            {
                this.damage -= 2;
            }

            return this.damage;
        }
        private int speedGenerator()
        {
            //TYPE
            Random setter = new Random();
            this.speed = setter.Next(10, 15);
            if (this.type == WeaponType.Sword)
            {
                this.speed += 10;
            }
            else if (this.type == WeaponType.Axe)
            {
                this.speed -= 15;
            }
            else if (this.type == WeaponType.Hammer)
            {
                this.speed -= 35;
            }
            else if (this.type == WeaponType.Spear)
            {
                this.speed += 20;
            }
            else if (this.type == WeaponType.Knife)
            {
                this.speed += 45;
            }

            //QUALITY
            if (this.quality == Quality.Broken)
            {
                this.speed -= 15;
            }
            else if (this.quality == Quality.Damaged)
            {
                this.speed -= 5;
            }
            else if (this.quality == Quality.Average)
            {
                this.speed += 0;
            }
            else if (this.quality == Quality.Crafted)
            {
                this.speed += 10;
            }
            else if (this.quality == Quality.Artifact)
            {
                this.speed += 20;
            }

            //SIZE
            if (this.size == Size.Large)
            {
                this.speed -= 15;
            }
            else if (this.size == Size.Average)
            {
                this.speed += 0;
            }
            else if (this.size == Size.Small)
            {
                this.speed += 20;
            }

            return this.speed;
        }

    }
}
