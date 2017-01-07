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

        }

        public Creature(int health, int damage, int armor, int strength, int agility, int speed)
        {
            this.health = health;
            this.damage = damage;
            this.armor = armor;
            this.strength = strength;
            this.agility = agility;
            this.speed = speed;
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


    }
}
