using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Program
{
    public class EnemyCreator
    {
        public Enemy StartUp()
        {
            return WhatType();
        }

        //Order of methods used: WhatType > HowDifficult
        public Enemy WhatType()
        {
            Random rnd = new Random();
            if (rnd.Next(1, 3) == 1)
            {
                Weapon banditWeapon = new Weapon();
                DifficultyLevel diff = HowDifficult("a bandit");
                Bandit enemy = new Bandit(diff, banditWeapon);
                return enemy;
            }
            else
            {
                DifficultyLevel diff = HowDifficult("a monster");
                Monster enemy = new Monster(diff);
                return enemy;
            }
        }

        public DifficultyLevel HowDifficult(string enemy)
        {
            Console.WriteLine("You meet {0}. How difficult do you think it'll be to deal with him?", enemy);
            Console.WriteLine("1. Easy 2. Medium 3. Hard");
            int difficulty = int.Parse(Console.ReadLine());

            if (difficulty == 1)
            {
                return DifficultyLevel.Easy;
            }
            else if (difficulty == 2)
            {
                return DifficultyLevel.Medium;
            }
            else
            {
                return DifficultyLevel.Hard;
            }
        }


    }
}
