using System;

namespace Main_Program
{
    class Creature
    {
        private int health;
        private int damage;
        private int armor;
        private int strength;
        private int agility;
        private int speed;

        public Creature()
        {
            generateHealth();
            generateDamage();
            generateArmor();
            generateStrength();
            generateAgility();
            generateSpeed();
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
            set { this.armor = value; }
        }

        public int Strength
        {
            get { return this.strength; }
            set { this.strength = value; }
        }

        public int Agility
        {
            get { return this.agility; }
            set { this.agility = value; }
        }

        public int Speed
        {
            get { return this.speed; }
            set { this.speed = value; }
        }

        public int generateHealth()
        {
            Random setter = new Random();
            this.health = setter.Next(130, 171);
            return health;
        }

        public int generateDamage()
        {
            Random setter = new Random();
            this.damage = setter.Next(3, 7);
            return damage;
        }

        public int generateArmor()
        {
            Random setter = new Random();
            this.armor = setter.Next(0, 2);
            return armor;
        }

        public int generateStrength()
        {
            Random setter = new Random();
            this.strength = setter.Next(5, 10);
            return strength;
        }

        public int generateAgility()
        {
            Random setter = new Random();
            this.agility = setter.Next(5, 10);
            return agility;
        }

        public int generateSpeed()
        {
            Random setter = new Random();
            this.speed = setter.Next(85, 115);
            return speed;
        }

    }
}
