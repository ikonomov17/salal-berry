using System;
using System.Threading;

namespace Main_Program
{
    public class Actions : IActions
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
            int didBothAttack = 0;
            int countHero = 0;
            int countEnemy = 0;

            while (MainEnemy.Health > 0 && MainHero.Health > 0)
            {
                Random rng = new Random();
                if (iniHero >= iniEnemy)
                {
                    if (Skills.Dodge(MainEnemy, MainHero))
                    {
                        Dodged(MainEnemy);
                    }
                    else
                    {
                        MainHero.Damage += rng.Next(-3, 13);
                        if (MainHero.Damage <= 0)
                        {
                            MainHero.Damage = 10;
                        }
                        Skills.PhysicalAttack(MainHero, MainEnemy);
                        countHero++;
                        iniHero -= iniEnemy;
                        didBothAttack++;
                    }
                }
                else
                {
                    if (Skills.Dodge(MainHero, MainEnemy))
                    {
                        Dodged(MainHero);
                    }
                    else
                    {
                        MainEnemy.Damage += rng.Next(-3, 13);
                        if (MainEnemy.Damage <= 0)
                        {
                            MainEnemy.Damage = 10;
                        }
                        Skills.PhysicalAttack(MainEnemy, MainHero);
                        iniEnemy -= iniHero;
                        countEnemy++;
                        didBothAttack++;
                    }
                }

                if (countHero - countEnemy == 5)
                {
                    Console.WriteLine("The hero is unleashing an unstoppable attack!");
                    Thread.Sleep(2000);
                    countEnemy = 0;
                    countHero = 0;
                }
                else if (countEnemy - countHero == 5)
                {
                    Console.WriteLine("The hero is completely overwhelmed by these attacks!");
                    Thread.Sleep(2000);
                    countEnemy = 0;
                    countHero = 0;
                }


                if (didBothAttack >= 2)
                {
                    Thread.Sleep(500);
                    didBothAttack = 0;
                }

                Thread.Sleep(500);

                if (MainEnemy.Health > 0 && MainHero.Health > 0)
                {
                    Console.Clear();
                }
            }

            if (MainEnemy.Health <= 0)
            {
                Victory();
            }else
            {
                Loss();
            }

        }

        public void Attacked()
        {
            Skills.PhysicalAttack(MainHero, MainEnemy);
        }

        public void Dodged(Creature one)
        {
            Console.WriteLine($"{one.GetType().Name} dodged an attack!");
            Thread.Sleep(1500);
        }

        public void Loss()
        {
            Console.WriteLine("The hero falls defeated! Unfortunately this enemy was too strong to beat!");
            TryAgain();
        }

        public void Victory()
        {
            Console.WriteLine("The hero is victorious! That was almost too easy!");
            TryAgain();
        }

        public void TryAgain()
        {
            Console.WriteLine("Do you want to try again with a new Hero?");
            Console.WriteLine("y/n");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "y")
            {
                Actions programStart = new Actions();
                programStart.Battle();
            }
            else
            {
                Console.WriteLine("Bye!");
                Thread.Sleep(1500);
            }
        }

    }
}
