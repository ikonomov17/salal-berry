using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Program
{
    public static class Skills
    {
        //AttackWithWeapon get's {Creature one} Strenght and Agility as bonus to it's attack and 
        //gets {Creature two's} armor to reduce the damage.

        public static void AttackWithWeapon(this Creature one, Creature two)
        {
            double damage = one.Damage + (one.Strength * 0.2) + (one.Agility * 0.2) - (two.Armor * 0.2);
            Console.WriteLine($"Creature one attacked creature two and caused {damage} damage!");
            //TODO change Health property access modifier
            //two.Health -= damage;
        }

        //Dodge method returns boolean which shows if {Creature one} will dodge {Creature two's} attack.

        public static bool Dodge(this Creature one, Creature two)
        {

            Random dodgeChance = new Random();
            int dodge = dodgeChance.Next(1, 100);
            //if this creature has below 50% health dodge chance increased!
            if (one.Health > (one.Health / 2))
            {
                double oneChance = (one.Agility * 0.2) + (one.Speed * 0.5);
                if (oneChance <= dodge)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                double oneChance = (one.Agility * 0.2) + (one.Speed * 0.2);
                if (oneChance <= dodge)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        //This method ignores {Creature two} armor and {Creature one} and has 25% bonus to his attack damage.
        public static void Prepare(this Creature one, Creature two)
        {
            double damage = (one.Agility * 0.2) + (one.Strength * 0.2);
            damage *= 0.25;
            //TODO change Health property access modifier
            //two.Health -= damage;
        }
    }
}
