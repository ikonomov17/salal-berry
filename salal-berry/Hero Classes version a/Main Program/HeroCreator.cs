using System;

namespace Main_Program
{
    public class HeroCreator : IHeroCreator
    {
        public Hero StartUp()
        {
            Console.WriteLine("**Type the number to make your choice.**");
            return ClassType();
        }

        //Order of methods used: ClassType > Gender > Size > Age > Weapon > WeaponType > WeaponSize > Armor > ArmorType
        public Hero ClassType()
        {
            Gender currentGen = Gender();
            Size currentSiz = Size();
            int currentAge = Age();

            Console.WriteLine("What is your training?");
            Console.WriteLine("1. Weapons 2. Magic");
            int type = int.Parse(Console.ReadLine());

            if (type == 1)
            {
                Warrior finishedWarrior = new Warrior(Weapon(), Armor(), currentGen, currentSiz, currentAge);
                return finishedWarrior;
            }
            else
            {
                Mage finishedMage = new Mage(Weapon(), currentGen, currentSiz, currentAge);
                return finishedMage;
            }
        }

        public Gender Gender()
        {
            Console.WriteLine("What is your gender?");
            Console.WriteLine("1. Male, 2. Female");
            int gender = int.Parse(Console.ReadLine());
            if (gender == 1)
            {
                return Main_Program.Gender.Male;
            }
            else
            {
                return Main_Program.Gender.Female;
            }
        }

        public Size Size()
        {
            Console.WriteLine("How big are you?");
            Console.WriteLine("1. Large, 2. Average, 3. Small");
            int size = int.Parse(Console.ReadLine());

            if (size == 1)
            {
                return Main_Program.Size.Large;
            }
            else if (size == 2)
            {
                return Main_Program.Size.Average;
            }
            else
            {
                return Main_Program.Size.Small;
            }
        }

        public int Age()
        {
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            return age;
        }

        public Weapon Weapon()
        {
            Console.WriteLine("You have to pick a weapon, what is it?");
            Console.WriteLine("1. Spear 2. Sword 3. Knife 4. Hammer 5. Axe");
            int type = int.Parse(Console.ReadLine());
            Console.WriteLine("How big is it?");
            Console.WriteLine("1. Large, 2. Average, 3. Small");
            int size = int.Parse(Console.ReadLine());
            Weapon current = new Weapon(WeaponType(type), WeaponSize(size));
            return current;
        }

        public WeaponType WeaponType(int type)
        {
            WeaponType wType = new WeaponType();
            switch (type)
            {
                case 1:
                    wType = Main_Program.WeaponType.Spear;
                    return wType;
                case 2:
                    wType = Main_Program.WeaponType.Sword;
                    return wType;
                case 3:
                    wType = Main_Program.WeaponType.Knife;
                    return wType;
                case 4:
                    wType = Main_Program.WeaponType.Hammer;
                    return wType;
                case 5:
                    wType = Main_Program.WeaponType.Axe;
                    return wType;

                //validate
                default:
                    wType = Main_Program.WeaponType.Spear;
                    return wType;
            }
        }

        public Size WeaponSize(int size)
        {
            Size wSize = new Size();
            switch (size)
            {
                case 1:
                    wSize = Main_Program.Size.Large;
                    return wSize;
                case 2:
                    wSize = Main_Program.Size.Average;
                    return wSize;
                case 3:
                    wSize = Main_Program.Size.Small;
                    return wSize;
                
                //validate
                default:
                    wSize = Main_Program.Size.Average;
                    return wSize;
            }
        }

        public Armor Armor()
        {
            Console.WriteLine("You see some armor lying around. You grab one made from...");
            Console.WriteLine("1. Leather 2. Mail 3. Plate");
            int type = int.Parse(Console.ReadLine());
            Armor current = new Armor(ArmorType(type));
            return current;
        }

        public ArmorType ArmorType(int type)
        {
            ArmorType aType = new ArmorType();
            switch (type)
            {
                case 1:
                    aType = Main_Program.ArmorType.leather;
                    return aType;
                case 2:
                    aType = Main_Program.ArmorType.mail;
                    return aType;
                case 3:
                    aType = Main_Program.ArmorType.plate;
                    return aType;

                //validate
                default:
                    aType = Main_Program.ArmorType.leather;
                    return aType;
            }
        }

    }
}
