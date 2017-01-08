using System;

namespace Main_Program
{
    class StartClass
    {
        static void Main()
        {
            ////creating a human > Hero
            ////health, damage, armor, strength, agility, speed
            //Creature human = new Creature(150, 10, 2, 5, 5, 100);
            ////gender, size, age 
            //Hero guy = new Hero(Gender.Male, Size.Average, 23, 150, 10, 2, 5, 5, 100);

            //guy.InitialInformation();
            //guy.AdditionalInformation();         
            //Console.WriteLine(guy.Health);

            ////creating a weapon
            //Weapon smallSword = new Weapon(WeaponType.Sword, Size.Small);
            //Console.WriteLine(smallSword.Damage + " " + smallSword.Quality);

			Creature test1 = new Warrior();
			Creature test2 = new Mage();
			Console.WriteLine(test1);
			Console.WriteLine(test2);
        }
    }
}