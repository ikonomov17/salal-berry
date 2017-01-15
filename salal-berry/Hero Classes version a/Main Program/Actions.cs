using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Main_Program
{
    public class Actions
    {
        private Hero mainHero;
        private Enemy mainEnemy;

        public Actions()
        {
            HeroCreator creatingHero = new HeroCreator();
            EnemyCreator creatingEnemy = new EnemyCreator();

            this.MainHero = creatingHero.StartUp();
            this.MainEnemy = creatingEnemy.StartUp();
        }

        public Hero MainHero
        {
            get { return this.mainHero; }
            set { this.mainHero = value; }
        }

        public Enemy MainEnemy
        {
            get { return this.mainEnemy; }
            set { this.mainEnemy = value; }
        }
   
        public void Battle()
        {
            Console.WriteLine("The enemy charges at you!");

            int iniHero = MainHero.Speed;
            int iniEnemy = MainEnemy.Speed;

            while (MainEnemy.Health > 0 || MainHero.Health > 0)
            {
                Console.WriteLine("enemy health" + MainEnemy.Health);
                Console.WriteLine("hero health" + MainHero.Health);
                int didBothAttack = 0;

                if (iniHero >= iniEnemy)
                {
                    Skills.PhysicalAttack(MainHero, MainEnemy);
                    iniHero -= iniEnemy;
                    didBothAttack++;
                }
                else
                {
                    Skills.PhysicalAttack(MainEnemy, MainHero);
                    iniEnemy -= iniHero;
                    didBothAttack++;
                }

                if (didBothAttack >= 2)
                {
                    Thread.Sleep(500);
                    didBothAttack = 0;
                }

                //DELETE 
                Thread.Sleep(500);

                Console.WriteLine("enemy speed " + MainEnemy.Speed);
                Console.WriteLine("hero speed " + MainHero.Speed);

                Console.WriteLine("enemy health " + MainEnemy.Health);
                Console.WriteLine("hero health " + MainHero.Health);
            }
        }

        public void Attacked()
        {
            Skills.PhysicalAttack(MainHero, MainEnemy);
        }

        public void Dodged()
        {

        }

        public void Speed(int iniHero, int iniEnemy)
        {
            //when both creatures attack, we pause for half a second


        }
    }
}
