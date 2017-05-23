using System;

namespace Main_Program
{
    public static class Magic
    {

        //Since Creature's health is between 130 and 171, the heal is 
        //10 % of Creature possible health.Invoke the method like this:
        //test1.Heal();

        public static int Heal(this Creature one)
        {
            Random rand = new Random();
            int heal = rand.Next(13, 17);
            return heal;
        }

        //Since Fireball is magic it ignores opponent's armor.
        //Causes random damage between 5 and 10
        //Creature one attacks creature two with fireball
        //Invoke method :  test1.Fireball(test2);

        public static int Fireball(this Creature one,Creature two)
        {
            Random rand = new Random();
            int fireball = rand.Next(5, 10);
            //TODO change Health access modifier
            //two.Health -= fireball;
            return fireball;
        }
    }
}
