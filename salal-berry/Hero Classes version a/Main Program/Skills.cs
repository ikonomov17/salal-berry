using System;

namespace Main_Program
{
    public static class Skills
    {
        public static int PhysicalAttack(this Creature one, Creature two)
        {
            int damage = one.Damage - two.Armor;
            Console.WriteLine($"{one.GetType().Name} attacked {two.GetType().Name} and caused {damage} damage!");
            two.Health -= damage;
            return two.Health;
        }

        //Dodge method returns boolean which shows if {Creature one} will dodge {Creature two's} attack.
        public static bool Dodge(this Creature one, Creature two)
        {
            Random dodgeChance = new Random();
            int dodge = (one.Agility - two.Agility) + dodgeChance.Next(1, 11) + one.Speed / 100;

            //if this creature has below 50% health dodge chance increased!
            if (one.Health >= (one.Health / 2))
            {
                dodge = dodge * 2;
            }

            if (dodge <= dodgeChance.Next(1, 101))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //This method ignores {Creature two} armor and {Creature one} and has 25% bonus to his attack damage.
        public static void Prepare(this Creature one, Creature two)
        {
            double damage = (one.Agility * 0.2) + (one.Strength * 0.2);
            damage *= 0.25;
            //TODO change Health property access modifier
            two.Health -= (int)damage;
        }
    }
}
