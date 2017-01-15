using System;
using System.Threading;

namespace Main_Program
{
    class StartClass
    {
        static void Main()
        {
            //Creature test1 = new Warrior();
            //Console.WriteLine(test1);
            //         Thread.Sleep(20);
            //Creature test2 = new Mage();
            //Console.WriteLine(test2);
            //         Thread.Sleep(20);
            //         Creature enemy1 = new Monster();
            //Console.WriteLine(enemy1);
            //         Thread.Sleep(20);
            //         Creature enemy2 = new Bandit();
            //Console.WriteLine(enemy2);

            Actions programStart = new Actions();
            programStart.Battle();
        }
    }
}