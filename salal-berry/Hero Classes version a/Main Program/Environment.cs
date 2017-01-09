
namespace Main_Program
{
    public static class Environment
    {
        // these methods influence of the creature's abilities 
         static void GetArmor(Creature creature)
        {
            creature.Armor += (int)Potentialities.Barracks;
        }

          static void GetHealth(Creature creature)
        {
            creature.Health += (int)Potentialities.RiverOfLife;
        }

          static void DoDamage(Creature creature)
        {
            creature.Damage -= (int)Potentialities.InvisibleTrap;
        }

          static void GetAgility(Creature creature)
        {
            creature.Health += (int)Potentialities.YogaТeacher;
        }

          static void GetSpeed(Creature creature)
        {
            creature.Damage -= (int)Potentialities.MagicTower;
        }

        static void GetStrength(Creature creature)
        {
            creature.Health += (int)Potentialities.Forrest;
        }
    }
}

