using System;

namespace Main_Program
{
    public class Random_Creature_Creator
    {
        public void HumanCreator()
        {
            GenerateGender();
            GenerateSize();
        }

        public Gender GenerateGender()
        {
            Random setter = new Random();
            if (setter.Next(1,3) == 1)
            {
                return Gender.Male;
            }
            else
            {
                return Gender.Female;
            }
        }

        public Size GenerateSize()
        {
            Random setter = new Random();
            if (setter.Next(1, 4) == 1)
            {
                return Size.Large;
            }
            else if (setter.Next(1, 4) == 2)
            {
                return Size.Average;
            }
            else
            {
                return Size.Small;
            }
        }

        public int GenerateAge()
        {
            Random setter = new Random();
            if (setter.Next(1, 3) == 1)
            {
                return 30;
            }
            else
            {
                return 45;
            }            
        }





    }
}
