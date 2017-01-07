using System;
using System.Collections.Generic;

namespace Main_Program
{
    public class Weapon
    {
        private WeaponType type;
        private Size size;
        private Quality quality;
        public int damage;
        private int speed;

        public Weapon()
        {

        }

        public Weapon(WeaponType type, Size size)
        {
            this.type = type;
            this.size = size;
            qualityGenerator();
            damageGenerator();
        }

        public int Damage
        {
            get { return this.damage; }
            private set { this.damage = value; }
        }


        public Quality Quality
        {
            get { return quality; }
            private set
            {
                this.quality = value;
            }
        }
        
        private Quality qualityGenerator()
        {
            Random setter = new Random();
            switch (setter.Next(1, 6))
            {
                case 1:
                    this.quality = Quality.Broken;
                    break;
                case 2:
                    this.quality = Quality.Damaged;
                    break;
                case 3:
                    this.quality = Quality.Average;
                    break;
                case 4:
                    this.quality = Quality.Crafted;
                    break;
                case 5:
                    this.quality = Quality.Artifact;
                    break;
            }
            return this.quality;
        }
        //weapon damage/speed are dependant on the type, size and quality
        private int damageGenerator()
        {
            //TYPE
            Random setter = new Random();
            this.damage = setter.Next(10, 15);
            if (type == WeaponType.Sword)
            {
                this.damage += 1;
            }
            else if (type == WeaponType.Axe)
            {
                this.damage += 3;
            }
            else if (type == WeaponType.Hammer)
            {
                this.damage += 7;                                
            }
            else if (type == WeaponType.Spear)
            {
                this.damage -= 1;
            }
            else if (type == WeaponType.Knife)
            {
                this.damage -= 4;
            }

            //QUALITY
            if (quality == Quality.Broken)
            {
                this.damage -= 3;
            }
            else if (quality == Quality.Damaged)
            {
                this.damage -= 1;
            }
            else if (quality == Quality.Average)
            {
                this.damage += 0;
            }
            else if (quality == Quality.Crafted)
            {
                this.damage += 2;
            }
            else if (quality == Quality.Artifact)
            {
                this.damage += 4;
            }

            //SIZE
            if (size == Size.Large)
            {
                this.damage += 3;
            }
            else if (size == Size.Average)
            {
                this.damage += 0;
            }
            else if (size == Size.Small)
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
            if (type == WeaponType.Sword)
            {
                this.speed += 10;
            }
            else if (type == WeaponType.Axe)
            {
                this.speed -= 15;
            }
            else if (type == WeaponType.Hammer)
            {
                this.speed -= 35;
            }
            else if (type == WeaponType.Spear)
            {
                this.speed += 20;
            }
            else if (type == WeaponType.Knife)
            {
                this.speed += 45;
            }

            //QUALITY
            if (quality == Quality.Broken)
            {
                this.speed -= 15;
            }
            else if (quality == Quality.Damaged)
            {
                this.speed -= 5;
            }
            else if (quality == Quality.Average)
            {
                this.speed += 0;
            }
            else if (quality == Quality.Crafted)
            {
                this.speed += 10;
            }
            else if (quality == Quality.Artifact)
            {
                this.speed += 20;
            }

            //SIZE
            if (size == Size.Large)
            {
                this.speed -= 15;
            }
            else if (size == Size.Average)
            {
                this.speed += 0;
            }
            else if (size == Size.Small)
            {
                this.speed += 20;
            }

            return this.speed;
        }

    }
}
