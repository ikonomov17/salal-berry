using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Program
{
    public class Armor
    {
        private int health;
        private int speed;
        private int armor;
        private ArmorType armortype;
        private Quality quality;

        private Armor()
        {

        }
        private Armor(int Health, int Speed, int Armor, ArmorType armorType, Quality Quality)
        {
            this.health = Health;
            this.speed = Speed;
            this.armor = Armor;
            this.armortype = armorType;
            this.quality = Quality;
        }


        public int Health
        {
            get {
                return this.health;
            }
            private set
            {
                this.health = value;
            }
        }
        public int Speed
        {
            get
            {
                return this.speed;
            }
            private set
            {
                this.speed = value;
            }
        }
        public int armor_prop
        {
            get
            {
                return this.armor;
            }
            private set
            {
                this.armor = value;
            }
        }
        public ArmorType armortype_prop
        {
            get
            {
                return this.armortype;
            }
            private set
            {
                this.armortype = value;
            }
        }
        public Quality quality_prop
        {
            get
            {
                return this.quality;
            }
            private set
            {
                this.quality = value;
            }
        }
    }
}
